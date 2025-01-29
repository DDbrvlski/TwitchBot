using System.Security.Cryptography;
using TwitchBot.Modules.Commands.Interfaces;
using TwitchBot.Modules.TwitchAPI.Interfaces;
using TwitchBot.Services.Form;
using TwitchBot.Views;

namespace TwitchBot
{
    public partial class BotForm : Form, IBotForm
    {
        private readonly IDeathCounter deathCounter;
        private readonly ITwitchCommands twitchCommands;
        private readonly ITwitchConnection twitchConnection;
        private readonly FormService formService;
        public BotForm
            (IDeathCounter deathCounter, 
            ITwitchCommands twitchCommands, 
            ITwitchConnection twitchConnection, 
            FormService formService)
        {
            InitializeComponent();
            if (deathCounter == null)
            {
                throw new ArgumentNullException(nameof(deathCounter), "DeathCounter nie zostało wstrzyknięte.");
            }
            this.twitchCommands = twitchCommands;
            this.formService = formService;
            formService.UpdateLogTextBox += UpdateLog;
            this.twitchConnection = twitchConnection;
            this.deathCounter = deathCounter;
            this.Text = "TwitchBot (offline)";
            LoadAllData();
        }

        #region Counter
        private void StartCounterButton_Click(object sender, EventArgs e)
        {
            deathCounter.StartCounter();
            CounterStatusLabelUpdate();
            BossStatusLabelUpdate();
            CurrentBossLabelUpdate();
            UpdateCounterLog("Uruchomiono licznik.");
        }

        private void StopCounterButton_Click(object sender, EventArgs e)
        {
            deathCounter.StopCounter();
            CounterStatusLabelUpdate();
            UpdateCounterLog("Zatrzymano licznik.");
        }

        private void AddDeathButton_Click(object sender, EventArgs e)
        {
            deathCounter.AddNewDeath();
            UpdateCounterLog("Dodano śmierć.");
        }

        private void RemoveDeathButton_Click(object sender, EventArgs e)
        {
            deathCounter.RemoveDeath();
            UpdateCounterLog("Usunięto śmierć.");
        }

        private void ResetDeathsButton_Click(object sender, EventArgs e)
        {
            deathCounter.ResetDeaths();
            UpdateCounterLog("Zresetowano licznik.");
        }

        private void StartBossButton_Click(object sender, EventArgs e)
        {
            if (BossNameTextBox.Text.Length > 0)
            {
                deathCounter.StartBoss(BossNameTextBox.Text);
                CurrentBossLabelUpdate();
                BossStatusLabelUpdate();
                UpdateCounterLog($"Rozpoczęto licznik bossa {BossNameTextBox.Text}.");
            }
        }
        private void ResumeBossButton_Click(object sender, EventArgs e)
        {
            deathCounter.ResumeBossCounter();
            CurrentBossLabelUpdate();
            BossStatusLabelUpdate();
            UpdateCounterLog("Wznowiono licznik boss.");
        }
        private void PauseBossButton_Click(object sender, EventArgs e)
        {
            deathCounter.PauseBoss();
            CurrentBossLabelUpdate();
            BossStatusLabelUpdate();
            UpdateCounterLog("Zatrzymano licznik bossa.");
        }
        private void EndBossButton_Click(object sender, EventArgs e)
        {
            deathCounter.StopBoss();
            CurrentBossLabelUpdate();
            BossStatusLabelUpdate();
            LoadStatsData();
            UpdateCounterLog("Zakończono licznik bossa.");
        }

        private void CounterStatusLabelUpdate()
        {
            if (deathCounter.CounterStatus())
            {
                CounterStatusLabel.Text = "Naliczanie AKTYWNE";
                CounterStatusLabel.ForeColor = Color.Green;
            }
            else
            {
                CounterStatusLabel.Text = "Naliczanie NIEAKTYWNE";
                CounterStatusLabel.ForeColor = Color.Red;
            }
        }
        private void CurrentBossLabelUpdate()
        {
            var bossStatus = deathCounter.BossStatus();
            if (bossStatus == Enums.BossStatusEnum.Active)
            {
                CurrentBossLabel.Text = "Aktualny boss: " + deathCounter.bossName;
                CurrentBossLabel.ForeColor = Color.Green;
            }
            else if (bossStatus == Enums.BossStatusEnum.Paused)
            {
                CurrentBossLabel.Text = "Aktualny boss: " + deathCounter.bossName;
                CurrentBossLabel.ForeColor = Color.Orange;
            }
            else
            {
                CurrentBossLabel.Text = "Aktualny boss: BRAK";
                CurrentBossLabel.ForeColor = Color.Red;
            }
        }
        private void BossStatusLabelUpdate()
        {
            var bossStatus = deathCounter.BossStatus();
            if (bossStatus == Enums.BossStatusEnum.Active)
            {
                BossStatusLabel.Text = "Status bossa: AKTYWNY";
                BossStatusLabel.ForeColor = Color.Green;
            }
            else if (bossStatus == Enums.BossStatusEnum.Paused)
            {
                BossStatusLabel.Text = "Status bossa: ZATRZYMANY";
                BossStatusLabel.ForeColor = Color.Orange;
            }
            else
            {
                BossStatusLabel.Text = "Status bossa: NIEAKTYWNY";
                BossStatusLabel.ForeColor = Color.Red;
            }
        }
        #endregion
        #region Stats
        private void LoadStatsData()
        {
            var stats = deathCounter.GetStats();
            statsDataGridView.Columns["bossNameColumn"].DataPropertyName = "bossName";
            statsDataGridView.Columns["deathCounterColumn"].DataPropertyName = "deathCounter";
            statsDataGridView.Columns["timerColumn"].DataPropertyName = "timer";
            statsDataGridView.DataSource = stats;
        }
        #endregion
        #region Commands
        public void GetAllCommands()
        {
            var commands = twitchCommands.GetAllPossibleCommands();
            CommandsDataGridView.DataSource = commands;
        }
        private void GetAllCounterUserPermissions()
        {
            var users = twitchCommands.GetAllUsersWithCounterPermissions();
            if (!CounterUserPermissionsDataGridView.Columns.Contains("Użytkownicy"))
            {
                var column = new DataGridViewTextBoxColumn();
                column.Name = "Użytkownicy";
                column.HeaderText = "Użytkownicy";
                CounterUserPermissionsDataGridView.Columns.Add(column);
            }
            CounterUserPermissionsDataGridView.Columns["Użytkownicy"].DataPropertyName = "UserName";
            CounterUserPermissionsDataGridView.DataSource = users;

        }
        #endregion
        #region Connection

        #endregion
        public void UpdateLog(string logMessage)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    LoggingTextBox.AppendText($"[{DateTime.UtcNow.ToString("HH:mm:ss")}] " + logMessage + Environment.NewLine);
                }));
            }
            else
            {
                LoggingTextBox.AppendText($"[{DateTime.UtcNow.ToString("HH:mm:ss")}] " + logMessage + Environment.NewLine);
            }
        }
        private void UpdateCounterLog(string logMessage)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    CounterLogsTextBox.AppendText($"[{DateTime.UtcNow.ToString("HH:mm:ss")}] " + logMessage + Environment.NewLine);
                }));
            }
            else
            {
                CounterLogsTextBox.AppendText($"[{DateTime.UtcNow.ToString("HH:mm:ss")}] " + logMessage + Environment.NewLine);
            }
        }
        private void LoggingTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        #region Data
        private void LoadAllData()
        {
            LoadStatsData();
            GetAllCommands();
            GetAllCounterUserPermissions();
        }
        #endregion
        private void CounterUserPermissionsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BotForm_Load(object sender, EventArgs e)
        {

        }

        private void TurnOnBotButton_Click(object sender, EventArgs e)
        {
            twitchConnection.Connection(true);

            if (twitchConnection.IsBotConnected())
            {
                BotStatusLabel.Text = "ONLINE";
                BotStatusLabel.ForeColor = Color.Green;
                this.Text = "TwitchBot (online)";
            }
        }

        private void TurnOffBotButton_Click(object sender, EventArgs e)
        {
            twitchConnection.Disconnect();

            if (!twitchConnection.IsBotConnected())
            {
                BotStatusLabel.Text = "OFFLINE";
                BotStatusLabel.ForeColor = Color.Red;
                this.Text = "TwitchBot (offline)";
            }
        }

        private void CounterLogsTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
