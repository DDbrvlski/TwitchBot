using TwitchBot.Modules.Commands.Interfaces;
using TwitchBot.Views;

namespace TwitchBot
{
    public partial class BotForm : Form, IBotForm
    {
        private readonly IDeathCounter deathCounter;
        public BotForm(IDeathCounter deathCounter)
        {
            InitializeComponent(); 
            if (deathCounter == null)
            {
                throw new ArgumentNullException(nameof(deathCounter), "DeathCounter nie zostało wstrzyknięte.");
            }
            this.deathCounter = deathCounter;
            LoadStatsData();
        }

        #region Counter
        private void StartCounterButton_Click(object sender, EventArgs e)
        {
            deathCounter.StartCounter();
            CounterStatusLabelUpdate();
            BossStatusLabelUpdate();
            CurrentBossLabelUpdate();
        }

        private void StopCounterButton_Click(object sender, EventArgs e)
        {
            deathCounter.StopCounter();
            CounterStatusLabelUpdate();
        }

        private void AddDeathButton_Click(object sender, EventArgs e)
        {
            deathCounter.AddNewDeath();
        }

        private void RemoveDeathButton_Click(object sender, EventArgs e)
        {
            deathCounter.RemoveDeath();
        }

        private void ResetDeathsButton_Click(object sender, EventArgs e)
        {
            deathCounter.ResetDeaths();
        }

        private void StartBossButton_Click(object sender, EventArgs e)
        {
            if (BossNameTextBox.Text.Length > 0)
            {
                deathCounter.StartBoss(BossNameTextBox.Text);
                CurrentBossLabelUpdate();
                BossStatusLabelUpdate();
            }
        }
        private void ResumeBossButton_Click(object sender, EventArgs e)
        {
            deathCounter.ResumeBossCounter();
            CurrentBossLabelUpdate();
            BossStatusLabelUpdate();
        }
        private void PauseBossButton_Click(object sender, EventArgs e)
        {
            deathCounter.PauseBoss();
            CurrentBossLabelUpdate();
            BossStatusLabelUpdate();
        }
        private void EndBossButton_Click(object sender, EventArgs e)
        {
            deathCounter.StopBoss();
            CurrentBossLabelUpdate();
            BossStatusLabelUpdate();
            LoadStatsData();
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
        public void UpdateLog(string logMessage)
        {
            if (InvokeRequired)
            {
                Invoke(new MethodInvoker(delegate
                {
                    LoggingTextBox.AppendText(logMessage + Environment.NewLine);
                }));
            }
            else
            {
                LoggingTextBox.AppendText(logMessage + Environment.NewLine);
            }
        }
        private void LoggingTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
