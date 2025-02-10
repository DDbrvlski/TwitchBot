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
        private readonly DataViewModel settingsViewModel;

        public BotForm(CounterViewModel viewModel, DataViewModel sviewModel)
        {
            InitializeComponent();
            botViewModel = viewModel;
            botViewModel.UpdateLogTextBox += UpdateLog;
            botViewModel.UpdateLabel += UpdateLabel;
            botViewModel.deathCounter.UpdateLogTextBoxDebug += UpdateLogDebug;
            settingsViewModel = sviewModel;
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
        public void GetAllCommands()
        {
            CommandsDataGridView.DataSource = null; 
            CommandsDataGridView.DataSource = botViewModel.Commands;
            CommandsDataGridView.AutoGenerateColumns = false;
            CommandsDataGridView.Columns["key"].HeaderText = "Komenda";
            CommandsDataGridView.Columns["category"].HeaderText = "Kategoria";
            CommandsDataGridView.Columns["description_pl"].HeaderText = "Opis";
            if (CommandsDataGridView.Columns.Contains("description_eng"))
            {
                CommandsDataGridView.Columns.Remove("description_eng");
            }
        }

        public void GetAllCounterUserPermissions()
        {
            CounterUserPermissionsDataGridView.DataSource = null;
            var users = botViewModel.UserPermissions;
            var displayList = new List<dynamic>();
            
            foreach (var userPermission in users.Categories)
            {
                foreach (var user in userPermission.Value)
                {
                    displayList.Add(new
                    {
                        Category = userPermission.Key,
                        User = user
                    });
                }
            }
            
            CounterUserPermissionsDataGridView.DataSource = displayList;

            CounterUserPermissionsDataGridView.AutoGenerateColumns = false;

            CounterUserPermissionsDataGridView.Columns["Category"].HeaderText = "Kategoria";
            CounterUserPermissionsDataGridView.Columns["User"].HeaderText = "Użytkownik";
        }
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
            GetAllCommands();
            GetAllCounterUserPermissions();
            LoadStatsData();
            LoadPanelSettingsData();
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
        private void UpdateLogDebug(string logMessage, LogTypeEnum logType)
        {
            string formattedMessage = $"[{DateTime.UtcNow:HH:mm:ss}] {logMessage}";
            if (DebugTextBox.InvokeRequired)
            {
                // Używamy Invoke, aby wykonać aktualizację w wątku UI
                DebugTextBox.Invoke(new Action(() =>
                {
                    // Tutaj aktualizujemy TextBox
                    DebugTextBox.AppendText($"{logMessage}" + Environment.NewLine);
                }));
            }
            else
            {
                // Jeśli już jesteśmy w wątku UI, możemy bezpośrednio zaktualizować kontrolkę
                DebugTextBox.AppendText($"Timer Debug Error");
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

        private void SaveSettings_Click(object sender, EventArgs e)
        {
            PanelDataDTO panelSettingsDTO = new PanelDataDTO()
            {
                twitchChannelName = TwitchAccountNameTextBox.Text,
                botClientID = TwitchBotClientIDTextBox.Text,
                botToken = TwitchBotTokenTextBox.Text
            };

            settingsViewModel.SavePanelData(panelSettingsDTO);
            MessageBox.Show("Zapisano zmiany");
        }

        private void LoadPanelSettingsData()
        {
            var settings = settingsViewModel.GetPanelSettings();

            TwitchAccountNameTextBox.Text = settings.twitchChannelName;
            TwitchBotClientIDTextBox.Text = settings.botClientID;
            TwitchBotTokenTextBox.Text = settings.botToken;
        }

        private void ExportTxtButton_Click(object sender, EventArgs e)
        {
            // Utwórz i skonfiguruj SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Pliki tekstowe (*.txt)|*.txt|Dokumenty Word (*.docx)|*.docx|Wszystkie pliki (*.*)|*.*";
            saveFileDialog.Title = "Wybierz miejsce zapisu pliku";

            // Pokaż okno dialogowe i sprawdź, czy użytkownik wybrał miejsce i kliknął "Zapisz"
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Tutaj możesz zapisać plik do wybranej lokalizacji
                string filePath = saveFileDialog.FileName;
                botViewModel.ExportBossStats(filePath);
                MessageBox.Show($"Plik zapisany jako: {filePath}");
            }
        }
    }

}
