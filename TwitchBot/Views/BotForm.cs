using System.Security.Cryptography;
using TwitchBot.Enums;
using TwitchBot.Models.DTO;
using TwitchBot.Services.Commands.Interfaces;
using TwitchBot.Services.Form;
using TwitchBot.Services.TwitchAPI.Interfaces;
using TwitchBot.ViewModels;
using TwitchBot.Views;
using TwitchLib.Api.Core.Enums;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TaskbarClock;

namespace TwitchBot
{
    public partial class BotForm : Form, IBotForm
    {
        private readonly CounterViewModel botViewModel;

        public BotForm(CounterViewModel viewModel)
        {
            InitializeComponent();
            botViewModel = viewModel;
            botViewModel.UpdateLogTextBox += UpdateLog;
            botViewModel.UpdateLabel += UpdateLabel;
            this.Text = "TwitchBot (offline)";
            LoadAllData();
        }

        #region Counter
        private void StartCounterButton_Click(object sender, EventArgs e) =>
            botViewModel.StartCounter();

        private void StopCounterButton_Click(object sender, EventArgs e) =>
            botViewModel.StopCounter();

        private void AddDeathButton_Click(object sender, EventArgs e) =>
            botViewModel.AddNewDeath();

        private void RemoveDeathButton_Click(object sender, EventArgs e) =>
            botViewModel.RemoveDeath();

        private void ResetDeathsButton_Click(object sender, EventArgs e) =>
            botViewModel.ResetDeaths();

        private void StartBossButton_Click(object sender, EventArgs e)
        {
            if (BossNameTextBox.Text.Length > 0)
                botViewModel.StartBoss(BossNameTextBox.Text);
            else
                UpdateLog("Nazwa bossa jest pusta.", LogTypeEnum.Counter);
        }

        private void ResumeBossButton_Click(object sender, EventArgs e) =>
            botViewModel.ResumeBoss();

        private void PauseBossButton_Click(object sender, EventArgs e) =>
            botViewModel.PauseBoss();

        private void EndBossButton_Click(object sender, EventArgs e) =>
            botViewModel.EndBoss();
        #endregion

        #region Stats
        private void LoadStatsData()
        {
            statsDataGridView.DataSource = null;
            statsDataGridView.DataSource = botViewModel.Stats;
            statsDataGridView.Columns["bossName"].HeaderText = "Nazwa Bossa";
            statsDataGridView.Columns["deathCounter"].HeaderText = "Liczba Zgonów";
            statsDataGridView.Columns["timer"].HeaderText = "Czas";

        }
        #endregion

        #region Commands
        public void GetAllCommands() =>
            CommandsDataGridView.DataSource = botViewModel.Commands;

        private void GetAllCounterUserPermissions() =>
            CounterUserPermissionsDataGridView.DataSource = botViewModel.UserPermissions;
        #endregion

        #region Connection
        private void TurnOnBotButton_Click(object sender, EventArgs e) =>
            botViewModel.TurnOnBot();

        private void TurnOffBotButton_Click(object sender, EventArgs e) =>
            botViewModel.TurnOffBot();
        #endregion

        #region Data
        private void LoadAllData()
        {
            botViewModel.LoadAllData();
            LoadStatsData();
        }

        #endregion

        private void UpdateLog(string logMessage, LogTypeEnum logType)
        {
            string formattedMessage = $"[{DateTime.UtcNow:HH:mm:ss}] {logMessage}";

            // Sprawdzenie, który typ logu
            if (logType == LogTypeEnum.Counter)
            {
                CounterLogsTextBox.AppendText($"{formattedMessage}" + Environment.NewLine);
            }
            else
            {
                LoggingTextBox.AppendText($"{formattedMessage}" + Environment.NewLine);
            }
        }

        public void UpdateLabel(string text, Color color, LabelTextEnum label)
        {
            switch (label)
            {
                case LabelTextEnum.CounterStatus:
                    CounterStatusLabel.Text = text;
                    CounterStatusLabel.ForeColor = color;
                    break;
                case LabelTextEnum.BossStatus:
                    BossStatusLabel.Text = text;
                    BossStatusLabel.ForeColor = color;
                    break;
                case LabelTextEnum.CurrentBoss:
                    CurrentBossLabel.Text = text;
                    CurrentBossLabel.ForeColor = color;
                    break;
                case LabelTextEnum.BotStatus:
                    BotStatusLabel.Text = text;
                    BotStatusLabel.ForeColor = color;
                    break;
            }
        }
        private void CounterLogsTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void SaveCustomCounterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(CustomCounterTextBox.Text);
                if (count >= 0)
                {
                    botViewModel.SetCounter(count);
                }
            }
            catch { }
        }

        private void SaveCustomBossCounterButton_Click(object sender, EventArgs e)
        {
            try
            {
                int count = int.Parse(CustomBossCounterTextBox.Text);
                if (count >= 0)
                {
                    botViewModel.SetBossCounter(count);
                }
            }
            catch { }
        }


        private void AddBossStatsButton_Click(object sender, EventArgs e)
        {
            AddBossStatForm dialog = new AddBossStatForm();
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                string bossName = dialog.BossName;
                int numberOfDeaths = dialog.NumberOfDeaths;
                string bossTime = dialog.Time;

                //MessageBox.Show($"Boss: {bossName}, Deaths: {numberOfDeaths}, Time: {bossTime}");

                botViewModel.AddNewBossStat(bossName, numberOfDeaths, bossTime);
                LoadStatsData();
            }
        }

        private void OpenAddBossStatForm_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void DeleteBossStatButton_Click(object sender, EventArgs e)
        {
            // Upewnij się, że coś jest zaznaczone
            if (statsDataGridView.SelectedRows.Count > 0)
            {
                // Pobierz indeks zaznaczonego wiersza
                var selectedRowIndex = statsDataGridView.SelectedRows[0].Index;

                // Pobierz dane z zaznaczonego wiersza (np. bossName, deathCounter, timer)
                string bossName = statsDataGridView.SelectedRows[0].Cells["bossName"].Value.ToString();

                // Wyświetl okno dialogowe z pytaniem o potwierdzenie
                var result = MessageBox.Show("Czy na pewno chcesz usunąć tego bossa?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                // Jeśli użytkownik kliknie "Yes", usuwamy wiersz
                if (result == DialogResult.Yes)
                {
                    botViewModel.RemoveBossStat(bossName);
                    LoadStatsData();
                    MessageBox.Show("Boss został usunięty.", "Sukces", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Usuwanie zostało anulowane.", "Anulowane", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Proszę wybrać wiersz do usunięcia.", "Błąd", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void statsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }

}
