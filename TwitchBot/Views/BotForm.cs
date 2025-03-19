using TwitchBot.Data;
using TwitchBot.Enums;
using TwitchBot.Models.DTO;
using TwitchBot.ViewModels;
using TwitchBot.Views;

namespace TwitchBot
{
    public partial class BotForm : Form, IBotForm
    {
        private readonly CounterViewModel botViewModel;
        private readonly DataViewModel settingsViewModel;
        private bool isListeningForShortcut = false;
        private bool isListeningForCommand = false;
        private ShortcutsEnum currentShortcut;
        public BotForm(CounterViewModel viewModel, DataViewModel sviewModel)
        {
            InitializeComponent();
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(BotForm_KeyDown);
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
            LoadShortcutsData();
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
            if (statsDataGridView.SelectedRows.Count > 0)
            {
                var selectedRowIndex = statsDataGridView.SelectedRows[0].Index;

                string bossName = statsDataGridView.SelectedRows[0].Cells["bossName"].Value.ToString();

                var result = MessageBox.Show("Czy na pewno chcesz usunąć tego bossa?", "Potwierdzenie", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

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

        private void label10_Click(object sender, EventArgs e)
        {

        }
        private void SetShortcutChangingLabel(string operation = "")
        {
            if (isListeningForShortcut)
            {
                ShortcutChangingLabel.Text = $"Nasłuchiwanie skrótu dla operacji {operation}.";
                ShortcutChangingLabel.ForeColor = Color.Green;
            }
            else
            {
                ShortcutChangingLabel.Text = "Nasłuchiwanie klawisza nieaktywne.";
                ShortcutChangingLabel.ForeColor = Color.Red;
            }
        }
        private void SetButtonShortcutText(string shortcutKey)
        {
            switch (currentShortcut)
            {
                case ShortcutsEnum.StartCounter:
                    StartCounterShortcutButton.Text = shortcutKey;
                    break;
                case ShortcutsEnum.StopCounter:
                    StopCounterShortcutButton.Text = shortcutKey;
                    break;
                case ShortcutsEnum.AddDeath:
                    AddDeathShortcutButton.Text = shortcutKey;
                    break;
                case ShortcutsEnum.RemoveDeath:
                    RemoveDeathShortcutButton.Text = shortcutKey;
                    break;
                case ShortcutsEnum.PauseBoss:
                    PauseBossShortcutButton.Text = shortcutKey;
                    break;
                case ShortcutsEnum.ResumeBoss:
                    ResumeBossShortcutButton.Text = shortcutKey;
                    break;
                case ShortcutsEnum.StopBoss:
                    StopBossShortcutButton.Text = shortcutKey;
                    break;
            }
        }
        private string KeyToString(Keys? key)
        {
            switch (key)
            {
                case Keys.OemPeriod:
                    return ".";
                case Keys.Oemcomma:
                    return ",";
                case Keys.OemMinus:
                    return "-";
                case Keys.Oemplus:
                    return "+";
                case Keys.OemQuestion:
                    return "?";
                case Keys.OemQuotes:
                    return "\"";
                case Keys.Space:
                    return "Space";
                case Keys.Enter:
                    return "Enter";
                case Keys.Escape:
                    return "Esc";
                case Keys.Tab:
                    return "Tab";
                case Keys.Add:
                    return "+ (NumPad)";
                case Keys.Subtract:
                    return "- (NumPad)";
                case Keys.Multiply:
                    return "* (NumPad)";
                case Keys.Divide:
                    return "/ (NumPad)";
                case Keys.Oem6:
                    return "]";
                case Keys.Oem4:
                    return "[";
                case Keys.OemPipe:
                    return "\\";
                case Keys.OemSemicolon:
                    return ";";
                case Keys.Oem3:
                    return "`";
                case Keys.Menu:
                    return "Alt";
                case Keys.Control:
                    return "Ctrl";
                case Keys.LMenu:
                    return "Lewy Alt";
                case Keys.LControlKey:
                    return "Lewy Ctrl";
                case Keys.RMenu:
                    return "Prawy Alt";
                case Keys.RControlKey:
                    return "Prawy Ctrl";
                case Keys.D1:
                    return "1";
                case Keys.D2:
                    return "2";
                case Keys.D3:
                    return "3";
                case Keys.D4:
                    return "4";
                case Keys.D5:
                    return "5";
                case Keys.D6:
                    return "6";
                case Keys.D7:
                    return "7";
                case Keys.D8:
                    return "8";
                case Keys.D9:
                    return "9";
                case Keys.D0:
                    return "0";
                case null:
                    return "Brak";
                default:
                    return key.ToString();
            }
        }
        private void StartCounterShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.StartCounter;
            ShortcutButton_Click();
        }
        private void StopCounterShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.StopCounter;
            ShortcutButton_Click();
        }
        private void AddDeathShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.AddDeath;
            ShortcutButton_Click();
        }
        private void RemoveDeathShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.RemoveDeath;
            ShortcutButton_Click();
        }
        private void PauseBossShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.PauseBoss;
            ShortcutButton_Click();
        }
        private void ResumeBossShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.ResumeBoss;
            ShortcutButton_Click();
        }
        private void StopBossShortcutButton_Click(object sender, EventArgs e)
        {
            currentShortcut = ShortcutsEnum.StopBoss;
            ShortcutButton_Click();
        }
        private void ShortcutButton_Click()
        {
            isListeningForShortcut = true;
            isListeningForCommand = false;
            string text = "";
            switch (currentShortcut)
            {
                case ShortcutsEnum.StartCounter:
                    text = "Start licznik";
                    break;
                case ShortcutsEnum.StopCounter:
                    text = "Stop licznik";
                    break;
                case ShortcutsEnum.AddDeath:
                    text = "Dodaj śmierć";
                    break;
                case ShortcutsEnum.RemoveDeath:
                    text = "Odejmij śmierć";
                    break;
                case ShortcutsEnum.PauseBoss:
                    text = "Zatrzymaj bossa";
                    break;
                case ShortcutsEnum.ResumeBoss:
                    text = "Wznów bossa";
                    break;
                case ShortcutsEnum.StopBoss:
                    text = "Zakończ bossa";
                    break;
            }
            SetShortcutChangingLabel(text);
        }
        private void BotForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (isListeningForCommand)
            {
                ProcessShortcutCommads(e.KeyCode);
            }
            if (isListeningForShortcut)
            {
                string keyString = KeyToString(e.KeyCode);
                ShortcutsViewModel.SetShortcut(currentShortcut, e.KeyCode);

                isListeningForShortcut = false;
                SetShortcutChangingLabel();
                SetButtonShortcutText(keyString);
                MessageBox.Show($"Przypisano skrót {keyString} do akcji {currentShortcut.ToString()}.");
                isListeningForCommand = true;
            }
        }
        private void LoadShortcutsData()
        {
            var shortcuts = ShortcutsViewModel.GetAllShortcuts();
            foreach (var shortcut in shortcuts)
            {
                currentShortcut = shortcut.Key;

                string keyString = KeyToString(shortcut.Value);
                SetButtonShortcutText(keyString);
            }
            isListeningForCommand = true;
        }
        private void ProcessShortcutCommads(Keys key)
        {
            var shortcuts = ShortcutsViewModel.GetAllShortcuts();
            foreach (var shortcut in shortcuts)
            {
                if (shortcut.Value == key)
                {
                    switch (shortcut.Key)
                    {
                        case ShortcutsEnum.StartCounter:
                            botViewModel.StartCounter();
                            break;
                        case ShortcutsEnum.StopCounter:
                            botViewModel.StopCounter();
                            break;
                        case ShortcutsEnum.AddDeath:
                            botViewModel.AddNewDeath();
                            break;
                        case ShortcutsEnum.RemoveDeath:
                            botViewModel.RemoveDeath();
                            break;
                        case ShortcutsEnum.PauseBoss:
                            botViewModel.PauseBoss();
                            break;
                        case ShortcutsEnum.ResumeBoss:
                            botViewModel.ResumeBoss();
                            break;
                        case ShortcutsEnum.StopBoss:
                            botViewModel.EndBoss();
                            break;
                    }
                    break;
                }
            }

        }
    }

}
