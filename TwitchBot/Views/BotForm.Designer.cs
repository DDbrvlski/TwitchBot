namespace TwitchBot
{
    partial class BotForm
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            tabControl1 = new TabControl();
            CounterTabPage = new TabPage();
            SaveCustomBossCounterButton = new Button();
            label6 = new Label();
            label5 = new Label();
            SaveCustomCounterButton = new Button();
            label4 = new Label();
            CustomBossCounterTextBox = new RichTextBox();
            CustomCounterTextBox = new RichTextBox();
            CounterLogsTextBox = new RichTextBox();
            ResumeBossButton = new Button();
            ResetDeathsButton = new Button();
            RemoveDeathButton = new Button();
            AddDeathButton = new Button();
            BossStatusLabel = new Label();
            CurrentBossLabel = new Label();
            CounterStatusLabel = new Label();
            EndBossButton = new Button();
            PauseBossButton = new Button();
            BossNameTextBox = new RichTextBox();
            StartBossButton = new Button();
            StopCounterButton = new Button();
            StartCounterButton = new Button();
            StatsTabPage = new TabPage();
            ExportTxtButton = new Button();
            DeleteBossStatButton = new Button();
            AddBossStatsButton = new Button();
            statsDataGridView = new DataGridView();
            AccountSettingTabPage = new TabPage();
            SaveSettings = new Button();
            TwitchBotTokenTextBox = new RichTextBox();
            label2 = new Label();
            TwitchBotClientIDTextBox = new RichTextBox();
            label1 = new Label();
            TwitchAccountNameTextBox = new RichTextBox();
            TwitchAccountNameLabel = new Label();
            CommandsTabPage = new TabPage();
            AddUserPermissionButton = new Button();
            AddCommandButton = new Button();
            CounterUserPermissionsDataGridView = new DataGridView();
            CommandsDataGridView = new DataGridView();
            LogsTabPage = new TabPage();
            LoggingTextBox = new RichTextBox();
            ActivationTabPage = new TabPage();
            BotStatusLabel = new Label();
            label3 = new Label();
            TurnOffBotButton = new Button();
            TurnOnBotButton = new Button();
            OpenAddBossStatForm = new OpenFileDialog();
            ModifyBossStatButton = new Button();
            DeleteUserPermissionsButton = new Button();
            DeleteCommandButton = new Button();
            tabControl1.SuspendLayout();
            CounterTabPage.SuspendLayout();
            StatsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statsDataGridView).BeginInit();
            AccountSettingTabPage.SuspendLayout();
            CommandsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CounterUserPermissionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommandsDataGridView).BeginInit();
            LogsTabPage.SuspendLayout();
            ActivationTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CounterTabPage);
            tabControl1.Controls.Add(StatsTabPage);
            tabControl1.Controls.Add(AccountSettingTabPage);
            tabControl1.Controls.Add(CommandsTabPage);
            tabControl1.Controls.Add(LogsTabPage);
            tabControl1.Controls.Add(ActivationTabPage);
            tabControl1.Location = new Point(5, 6);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(793, 550);
            tabControl1.TabIndex = 0;
            // 
            // CounterTabPage
            // 
            CounterTabPage.Controls.Add(SaveCustomBossCounterButton);
            CounterTabPage.Controls.Add(label6);
            CounterTabPage.Controls.Add(label5);
            CounterTabPage.Controls.Add(SaveCustomCounterButton);
            CounterTabPage.Controls.Add(label4);
            CounterTabPage.Controls.Add(CustomBossCounterTextBox);
            CounterTabPage.Controls.Add(CustomCounterTextBox);
            CounterTabPage.Controls.Add(CounterLogsTextBox);
            CounterTabPage.Controls.Add(ResumeBossButton);
            CounterTabPage.Controls.Add(ResetDeathsButton);
            CounterTabPage.Controls.Add(RemoveDeathButton);
            CounterTabPage.Controls.Add(AddDeathButton);
            CounterTabPage.Controls.Add(BossStatusLabel);
            CounterTabPage.Controls.Add(CurrentBossLabel);
            CounterTabPage.Controls.Add(CounterStatusLabel);
            CounterTabPage.Controls.Add(EndBossButton);
            CounterTabPage.Controls.Add(PauseBossButton);
            CounterTabPage.Controls.Add(BossNameTextBox);
            CounterTabPage.Controls.Add(StartBossButton);
            CounterTabPage.Controls.Add(StopCounterButton);
            CounterTabPage.Controls.Add(StartCounterButton);
            CounterTabPage.Location = new Point(4, 29);
            CounterTabPage.Margin = new Padding(3, 4, 3, 4);
            CounterTabPage.Name = "CounterTabPage";
            CounterTabPage.Padding = new Padding(3, 4, 3, 4);
            CounterTabPage.Size = new Size(785, 517);
            CounterTabPage.TabIndex = 0;
            CounterTabPage.Text = "Licznik";
            CounterTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveCustomBossCounterButton
            // 
            SaveCustomBossCounterButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SaveCustomBossCounterButton.Location = new Point(210, 251);
            SaveCustomBossCounterButton.Margin = new Padding(3, 4, 3, 4);
            SaveCustomBossCounterButton.Name = "SaveCustomBossCounterButton";
            SaveCustomBossCounterButton.Size = new Size(81, 32);
            SaveCustomBossCounterButton.TabIndex = 20;
            SaveCustomBossCounterButton.Text = "Zapisz";
            SaveCustomBossCounterButton.UseVisualStyleBackColor = true;
            SaveCustomBossCounterButton.Click += SaveCustomBossCounterButton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label6.ForeColor = Color.Black;
            label6.Location = new Point(16, 261);
            label6.Name = "label6";
            label6.Size = new Size(73, 20);
            label6.TabIndex = 19;
            label6.Text = "2. Boss";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label5.ForeColor = Color.Black;
            label5.Location = new Point(16, 223);
            label5.Name = "label5";
            label5.Size = new Size(90, 20);
            label5.TabIndex = 18;
            label5.Text = "1. Licznik";
            // 
            // SaveCustomCounterButton
            // 
            SaveCustomCounterButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SaveCustomCounterButton.Location = new Point(210, 214);
            SaveCustomCounterButton.Margin = new Padding(3, 4, 3, 4);
            SaveCustomCounterButton.Name = "SaveCustomCounterButton";
            SaveCustomCounterButton.Size = new Size(81, 29);
            SaveCustomCounterButton.TabIndex = 17;
            SaveCustomCounterButton.Text = "Zapisz";
            SaveCustomCounterButton.UseVisualStyleBackColor = true;
            SaveCustomCounterButton.Click += SaveCustomCounterButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            label4.ForeColor = Color.Black;
            label4.Location = new Point(16, 173);
            label4.Name = "label4";
            label4.Size = new Size(217, 20);
            label4.TabIndex = 16;
            label4.Text = "Niestandardowe śmierci:";
            // 
            // CustomBossCounterTextBox
            // 
            CustomBossCounterTextBox.Location = new Point(125, 220);
            CustomBossCounterTextBox.Margin = new Padding(3, 4, 3, 4);
            CustomBossCounterTextBox.Name = "CustomBossCounterTextBox";
            CustomBossCounterTextBox.Size = new Size(53, 25);
            CustomBossCounterTextBox.TabIndex = 15;
            CustomBossCounterTextBox.Text = "0";
            // 
            // CustomCounterTextBox
            // 
            CustomCounterTextBox.Location = new Point(125, 258);
            CustomCounterTextBox.Margin = new Padding(3, 4, 3, 4);
            CustomCounterTextBox.Name = "CustomCounterTextBox";
            CustomCounterTextBox.Size = new Size(53, 25);
            CustomCounterTextBox.TabIndex = 14;
            CustomCounterTextBox.Text = "0";
            // 
            // CounterLogsTextBox
            // 
            CounterLogsTextBox.Location = new Point(16, 334);
            CounterLogsTextBox.Margin = new Padding(3, 4, 3, 4);
            CounterLogsTextBox.Name = "CounterLogsTextBox";
            CounterLogsTextBox.Size = new Size(348, 166);
            CounterLogsTextBox.TabIndex = 13;
            CounterLogsTextBox.Text = "";
            CounterLogsTextBox.TextChanged += CounterLogsTextBox_TextChanged;
            // 
            // ResumeBossButton
            // 
            ResumeBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ResumeBossButton.Location = new Point(598, 79);
            ResumeBossButton.Margin = new Padding(3, 4, 3, 4);
            ResumeBossButton.Name = "ResumeBossButton";
            ResumeBossButton.Size = new Size(164, 50);
            ResumeBossButton.TabIndex = 12;
            ResumeBossButton.Text = "Wznów bossa";
            ResumeBossButton.UseVisualStyleBackColor = true;
            ResumeBossButton.Click += ResumeBossButton_Click;
            // 
            // ResetDeathsButton
            // 
            ResetDeathsButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ResetDeathsButton.Location = new Point(261, 23);
            ResetDeathsButton.Margin = new Padding(3, 4, 3, 4);
            ResetDeathsButton.Name = "ResetDeathsButton";
            ResetDeathsButton.Size = new Size(103, 49);
            ResetDeathsButton.TabIndex = 11;
            ResetDeathsButton.Text = "Reset";
            ResetDeathsButton.UseVisualStyleBackColor = true;
            ResetDeathsButton.Click += ResetDeathsButton_Click;
            // 
            // RemoveDeathButton
            // 
            RemoveDeathButton.Font = new Font("Microsoft Sans Serif", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RemoveDeathButton.Location = new Point(122, 98);
            RemoveDeathButton.Margin = new Padding(3, 4, 3, 4);
            RemoveDeathButton.Name = "RemoveDeathButton";
            RemoveDeathButton.Size = new Size(65, 50);
            RemoveDeathButton.TabIndex = 10;
            RemoveDeathButton.Text = "-";
            RemoveDeathButton.UseVisualStyleBackColor = true;
            RemoveDeathButton.Click += RemoveDeathButton_Click;
            // 
            // AddDeathButton
            // 
            AddDeathButton.Font = new Font("Microsoft Sans Serif", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddDeathButton.Location = new Point(16, 98);
            AddDeathButton.Margin = new Padding(3, 4, 3, 4);
            AddDeathButton.Name = "AddDeathButton";
            AddDeathButton.Size = new Size(73, 50);
            AddDeathButton.TabIndex = 9;
            AddDeathButton.Text = "+";
            AddDeathButton.UseVisualStyleBackColor = true;
            AddDeathButton.Click += AddDeathButton_Click;
            // 
            // BossStatusLabel
            // 
            BossStatusLabel.AutoSize = true;
            BossStatusLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            BossStatusLabel.ForeColor = Color.Red;
            BossStatusLabel.Location = new Point(414, 464);
            BossStatusLabel.Name = "BossStatusLabel";
            BossStatusLabel.Size = new Size(225, 20);
            BossStatusLabel.TabIndex = 8;
            BossStatusLabel.Text = "Status bossa: Nieaktywny";
            // 
            // CurrentBossLabel
            // 
            CurrentBossLabel.AutoSize = true;
            CurrentBossLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CurrentBossLabel.ForeColor = Color.Red;
            CurrentBossLabel.Location = new Point(414, 420);
            CurrentBossLabel.Name = "CurrentBossLabel";
            CurrentBossLabel.Size = new Size(177, 20);
            CurrentBossLabel.TabIndex = 7;
            CurrentBossLabel.Text = "Aktualny boss: Brak";
            // 
            // CounterStatusLabel
            // 
            CounterStatusLabel.AutoSize = true;
            CounterStatusLabel.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 238);
            CounterStatusLabel.ForeColor = Color.Red;
            CounterStatusLabel.Location = new Point(418, 379);
            CounterStatusLabel.Name = "CounterStatusLabel";
            CounterStatusLabel.Size = new Size(195, 20);
            CounterStatusLabel.TabIndex = 6;
            CounterStatusLabel.Text = "Naliczanie nieaktywne";
            // 
            // EndBossButton
            // 
            EndBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EndBossButton.Location = new Point(598, 143);
            EndBossButton.Margin = new Padding(3, 4, 3, 4);
            EndBossButton.Name = "EndBossButton";
            EndBossButton.Size = new Size(164, 50);
            EndBossButton.TabIndex = 5;
            EndBossButton.Text = "Zakończ bossa";
            EndBossButton.UseVisualStyleBackColor = true;
            EndBossButton.Click += EndBossButton_Click;
            // 
            // PauseBossButton
            // 
            PauseBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            PauseBossButton.Location = new Point(416, 143);
            PauseBossButton.Margin = new Padding(3, 4, 3, 4);
            PauseBossButton.Name = "PauseBossButton";
            PauseBossButton.Size = new Size(164, 50);
            PauseBossButton.TabIndex = 4;
            PauseBossButton.Text = "Zatrzymaj bossa";
            PauseBossButton.UseVisualStyleBackColor = true;
            PauseBossButton.Click += PauseBossButton_Click;
            // 
            // BossNameTextBox
            // 
            BossNameTextBox.Location = new Point(418, 23);
            BossNameTextBox.Margin = new Padding(3, 4, 3, 4);
            BossNameTextBox.Name = "BossNameTextBox";
            BossNameTextBox.Size = new Size(344, 36);
            BossNameTextBox.TabIndex = 3;
            BossNameTextBox.Text = "";
            // 
            // StartBossButton
            // 
            StartBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartBossButton.Location = new Point(418, 79);
            StartBossButton.Margin = new Padding(3, 4, 3, 4);
            StartBossButton.Name = "StartBossButton";
            StartBossButton.Size = new Size(164, 50);
            StartBossButton.TabIndex = 2;
            StartBossButton.Text = "Rozpocznij bossa";
            StartBossButton.UseVisualStyleBackColor = true;
            StartBossButton.Click += StartBossButton_Click;
            // 
            // StopCounterButton
            // 
            StopCounterButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StopCounterButton.Location = new Point(130, 22);
            StopCounterButton.Margin = new Padding(3, 4, 3, 4);
            StopCounterButton.Name = "StopCounterButton";
            StopCounterButton.Size = new Size(103, 49);
            StopCounterButton.TabIndex = 1;
            StopCounterButton.Text = "Stop";
            StopCounterButton.UseVisualStyleBackColor = true;
            StopCounterButton.Click += StopCounterButton_Click;
            // 
            // StartCounterButton
            // 
            StartCounterButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartCounterButton.Location = new Point(16, 21);
            StartCounterButton.Margin = new Padding(3, 4, 3, 4);
            StartCounterButton.Name = "StartCounterButton";
            StartCounterButton.Size = new Size(103, 51);
            StartCounterButton.TabIndex = 0;
            StartCounterButton.Text = "Start";
            StartCounterButton.UseVisualStyleBackColor = true;
            StartCounterButton.Click += StartCounterButton_Click;
            // 
            // StatsTabPage
            // 
            StatsTabPage.Controls.Add(ModifyBossStatButton);
            StatsTabPage.Controls.Add(ExportTxtButton);
            StatsTabPage.Controls.Add(DeleteBossStatButton);
            StatsTabPage.Controls.Add(AddBossStatsButton);
            StatsTabPage.Controls.Add(statsDataGridView);
            StatsTabPage.Location = new Point(4, 29);
            StatsTabPage.Margin = new Padding(3, 4, 3, 4);
            StatsTabPage.Name = "StatsTabPage";
            StatsTabPage.Size = new Size(785, 517);
            StatsTabPage.TabIndex = 1;
            StatsTabPage.Text = "Stats";
            StatsTabPage.UseVisualStyleBackColor = true;
            // 
            // ExportTxtButton
            // 
            ExportTxtButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ExportTxtButton.Location = new Point(631, 471);
            ExportTxtButton.Margin = new Padding(3, 4, 3, 4);
            ExportTxtButton.Name = "ExportTxtButton";
            ExportTxtButton.Size = new Size(151, 43);
            ExportTxtButton.TabIndex = 22;
            ExportTxtButton.Text = "Eksportuj do txt";
            ExportTxtButton.UseVisualStyleBackColor = true;
            ExportTxtButton.Click += ExportTxtButton_Click;
            // 
            // DeleteBossStatButton
            // 
            DeleteBossStatButton.Location = new Point(345, 470);
            DeleteBossStatButton.Name = "DeleteBossStatButton";
            DeleteBossStatButton.Size = new Size(124, 44);
            DeleteBossStatButton.TabIndex = 2;
            DeleteBossStatButton.Text = "Usuń";
            DeleteBossStatButton.UseVisualStyleBackColor = true;
            DeleteBossStatButton.Click += DeleteBossStatButton_Click;
            // 
            // AddBossStatsButton
            // 
            AddBossStatsButton.Location = new Point(3, 470);
            AddBossStatsButton.Name = "AddBossStatsButton";
            AddBossStatsButton.Size = new Size(124, 44);
            AddBossStatsButton.TabIndex = 1;
            AddBossStatsButton.Text = "Dodaj";
            AddBossStatsButton.UseVisualStyleBackColor = true;
            AddBossStatsButton.Click += AddBossStatsButton_Click;
            // 
            // statsDataGridView
            // 
            statsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statsDataGridView.Location = new Point(3, 4);
            statsDataGridView.Margin = new Padding(3, 4, 3, 4);
            statsDataGridView.Name = "statsDataGridView";
            statsDataGridView.RowHeadersWidth = 51;
            statsDataGridView.RowTemplate.Height = 24;
            statsDataGridView.Size = new Size(782, 459);
            statsDataGridView.TabIndex = 0;
            statsDataGridView.CellContentClick += statsDataGridView_CellContentClick;
            // 
            // AccountSettingTabPage
            // 
            AccountSettingTabPage.Controls.Add(SaveSettings);
            AccountSettingTabPage.Controls.Add(TwitchBotTokenTextBox);
            AccountSettingTabPage.Controls.Add(label2);
            AccountSettingTabPage.Controls.Add(TwitchBotClientIDTextBox);
            AccountSettingTabPage.Controls.Add(label1);
            AccountSettingTabPage.Controls.Add(TwitchAccountNameTextBox);
            AccountSettingTabPage.Controls.Add(TwitchAccountNameLabel);
            AccountSettingTabPage.Location = new Point(4, 29);
            AccountSettingTabPage.Margin = new Padding(3, 4, 3, 4);
            AccountSettingTabPage.Name = "AccountSettingTabPage";
            AccountSettingTabPage.Size = new Size(785, 517);
            AccountSettingTabPage.TabIndex = 2;
            AccountSettingTabPage.Text = "Ustawienia konta";
            AccountSettingTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveSettings
            // 
            SaveSettings.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SaveSettings.Location = new Point(19, 451);
            SaveSettings.Margin = new Padding(3, 4, 3, 4);
            SaveSettings.Name = "SaveSettings";
            SaveSettings.Size = new Size(132, 41);
            SaveSettings.TabIndex = 6;
            SaveSettings.Text = "Zapisz ustawienia";
            SaveSettings.UseVisualStyleBackColor = true;
            SaveSettings.Click += SaveSettings_Click;
            // 
            // TwitchBotTokenTextBox
            // 
            TwitchBotTokenTextBox.Location = new Point(19, 248);
            TwitchBotTokenTextBox.Margin = new Padding(3, 4, 3, 4);
            TwitchBotTokenTextBox.Name = "TwitchBotTokenTextBox";
            TwitchBotTokenTextBox.Size = new Size(395, 33);
            TwitchBotTokenTextBox.TabIndex = 5;
            TwitchBotTokenTextBox.Text = "";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label2.Location = new Point(15, 216);
            label2.Name = "label2";
            label2.Size = new Size(151, 22);
            label2.TabIndex = 4;
            label2.Text = "Twitch Bot Token";
            // 
            // TwitchBotClientIDTextBox
            // 
            TwitchBotClientIDTextBox.Location = new Point(19, 140);
            TwitchBotClientIDTextBox.Margin = new Padding(3, 4, 3, 4);
            TwitchBotClientIDTextBox.Name = "TwitchBotClientIDTextBox";
            TwitchBotClientIDTextBox.Size = new Size(395, 33);
            TwitchBotClientIDTextBox.TabIndex = 3;
            TwitchBotClientIDTextBox.Text = "";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label1.Location = new Point(15, 109);
            label1.Name = "label1";
            label1.Size = new Size(173, 22);
            label1.TabIndex = 2;
            label1.Text = "Twitch Bot Client ID ";
            // 
            // TwitchAccountNameTextBox
            // 
            TwitchAccountNameTextBox.Location = new Point(19, 49);
            TwitchAccountNameTextBox.Margin = new Padding(3, 4, 3, 4);
            TwitchAccountNameTextBox.Name = "TwitchAccountNameTextBox";
            TwitchAccountNameTextBox.Size = new Size(395, 33);
            TwitchAccountNameTextBox.TabIndex = 1;
            TwitchAccountNameTextBox.Text = "";
            // 
            // TwitchAccountNameLabel
            // 
            TwitchAccountNameLabel.AutoSize = true;
            TwitchAccountNameLabel.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TwitchAccountNameLabel.Location = new Point(15, 18);
            TwitchAccountNameLabel.Name = "TwitchAccountNameLabel";
            TwitchAccountNameLabel.Size = new Size(173, 22);
            TwitchAccountNameLabel.TabIndex = 0;
            TwitchAccountNameLabel.Text = "Nazwa kanału twitch";
            // 
            // CommandsTabPage
            // 
            CommandsTabPage.Controls.Add(DeleteCommandButton);
            CommandsTabPage.Controls.Add(DeleteUserPermissionsButton);
            CommandsTabPage.Controls.Add(AddUserPermissionButton);
            CommandsTabPage.Controls.Add(AddCommandButton);
            CommandsTabPage.Controls.Add(CounterUserPermissionsDataGridView);
            CommandsTabPage.Controls.Add(CommandsDataGridView);
            CommandsTabPage.Location = new Point(4, 29);
            CommandsTabPage.Margin = new Padding(3, 4, 3, 4);
            CommandsTabPage.Name = "CommandsTabPage";
            CommandsTabPage.Size = new Size(785, 517);
            CommandsTabPage.TabIndex = 3;
            CommandsTabPage.Text = "Komendy";
            CommandsTabPage.UseVisualStyleBackColor = true;
            // 
            // AddUserPermissionButton
            // 
            AddUserPermissionButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddUserPermissionButton.Location = new Point(418, 454);
            AddUserPermissionButton.Margin = new Padding(3, 4, 3, 4);
            AddUserPermissionButton.Name = "AddUserPermissionButton";
            AddUserPermissionButton.Size = new Size(102, 41);
            AddUserPermissionButton.TabIndex = 7;
            AddUserPermissionButton.Text = "Dodaj";
            AddUserPermissionButton.UseVisualStyleBackColor = true;
            // 
            // AddCommandButton
            // 
            AddCommandButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddCommandButton.Location = new Point(18, 454);
            AddCommandButton.Margin = new Padding(3, 4, 3, 4);
            AddCommandButton.Name = "AddCommandButton";
            AddCommandButton.Size = new Size(102, 41);
            AddCommandButton.TabIndex = 6;
            AddCommandButton.Text = "Dodaj";
            AddCommandButton.UseVisualStyleBackColor = true;
            // 
            // CounterUserPermissionsDataGridView
            // 
            CounterUserPermissionsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CounterUserPermissionsDataGridView.Location = new Point(418, 16);
            CounterUserPermissionsDataGridView.Margin = new Padding(3, 4, 3, 4);
            CounterUserPermissionsDataGridView.Name = "CounterUserPermissionsDataGridView";
            CounterUserPermissionsDataGridView.RowHeadersWidth = 51;
            CounterUserPermissionsDataGridView.RowTemplate.Height = 24;
            CounterUserPermissionsDataGridView.Size = new Size(343, 430);
            CounterUserPermissionsDataGridView.TabIndex = 4;
            // 
            // CommandsDataGridView
            // 
            CommandsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            CommandsDataGridView.Location = new Point(18, 16);
            CommandsDataGridView.Margin = new Padding(3, 4, 3, 4);
            CommandsDataGridView.Name = "CommandsDataGridView";
            CommandsDataGridView.RowHeadersWidth = 51;
            CommandsDataGridView.RowTemplate.Height = 24;
            CommandsDataGridView.Size = new Size(343, 430);
            CommandsDataGridView.TabIndex = 3;
            // 
            // LogsTabPage
            // 
            LogsTabPage.Controls.Add(LoggingTextBox);
            LogsTabPage.Location = new Point(4, 29);
            LogsTabPage.Margin = new Padding(3, 4, 3, 4);
            LogsTabPage.Name = "LogsTabPage";
            LogsTabPage.Size = new Size(785, 517);
            LogsTabPage.TabIndex = 4;
            LogsTabPage.Text = "Logi";
            LogsTabPage.UseVisualStyleBackColor = true;
            // 
            // LoggingTextBox
            // 
            LoggingTextBox.Location = new Point(3, 4);
            LoggingTextBox.Margin = new Padding(3, 4, 3, 4);
            LoggingTextBox.Name = "LoggingTextBox";
            LoggingTextBox.Size = new Size(779, 505);
            LoggingTextBox.TabIndex = 0;
            LoggingTextBox.Text = "";
            // 
            // ActivationTabPage
            // 
            ActivationTabPage.Controls.Add(BotStatusLabel);
            ActivationTabPage.Controls.Add(label3);
            ActivationTabPage.Controls.Add(TurnOffBotButton);
            ActivationTabPage.Controls.Add(TurnOnBotButton);
            ActivationTabPage.Location = new Point(4, 29);
            ActivationTabPage.Name = "ActivationTabPage";
            ActivationTabPage.Size = new Size(785, 517);
            ActivationTabPage.TabIndex = 5;
            ActivationTabPage.Text = "Panel";
            ActivationTabPage.UseVisualStyleBackColor = true;
            // 
            // BotStatusLabel
            // 
            BotStatusLabel.AutoSize = true;
            BotStatusLabel.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            BotStatusLabel.ForeColor = Color.Red;
            BotStatusLabel.Location = new Point(537, 79);
            BotStatusLabel.Name = "BotStatusLabel";
            BotStatusLabel.Size = new Size(86, 28);
            BotStatusLabel.TabIndex = 3;
            BotStatusLabel.Text = "OFFLINE";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            label3.Location = new Point(486, 21);
            label3.Name = "label3";
            label3.Size = new Size(185, 38);
            label3.TabIndex = 2;
            label3.Text = "STATUS BOTA";
            // 
            // TurnOffBotButton
            // 
            TurnOffBotButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TurnOffBotButton.Location = new Point(46, 309);
            TurnOffBotButton.Name = "TurnOffBotButton";
            TurnOffBotButton.Size = new Size(130, 49);
            TurnOffBotButton.TabIndex = 1;
            TurnOffBotButton.Text = "Wyłącz";
            TurnOffBotButton.UseVisualStyleBackColor = true;
            TurnOffBotButton.Click += TurnOffBotButton_Click;
            // 
            // TurnOnBotButton
            // 
            TurnOnBotButton.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TurnOnBotButton.Location = new Point(46, 176);
            TurnOnBotButton.Name = "TurnOnBotButton";
            TurnOnBotButton.Size = new Size(130, 44);
            TurnOnBotButton.TabIndex = 0;
            TurnOnBotButton.Text = "Uruchom bota";
            TurnOnBotButton.UseVisualStyleBackColor = true;
            TurnOnBotButton.Click += TurnOnBotButton_Click;
            // 
            // OpenAddBossStatForm
            // 
            OpenAddBossStatForm.FileName = "AddBossStatForm";
            OpenAddBossStatForm.FileOk += OpenAddBossStatForm_FileOk;
            // 
            // ModifyBossStatButton
            // 
            ModifyBossStatButton.Location = new Point(174, 470);
            ModifyBossStatButton.Name = "ModifyBossStatButton";
            ModifyBossStatButton.Size = new Size(124, 44);
            ModifyBossStatButton.TabIndex = 23;
            ModifyBossStatButton.Text = "Edytuj";
            ModifyBossStatButton.UseVisualStyleBackColor = true;
            // 
            // DeleteUserPermissionsButton
            // 
            DeleteUserPermissionsButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DeleteUserPermissionsButton.Location = new Point(659, 454);
            DeleteUserPermissionsButton.Margin = new Padding(3, 4, 3, 4);
            DeleteUserPermissionsButton.Name = "DeleteUserPermissionsButton";
            DeleteUserPermissionsButton.Size = new Size(102, 41);
            DeleteUserPermissionsButton.TabIndex = 8;
            DeleteUserPermissionsButton.Text = "Usuń";
            DeleteUserPermissionsButton.UseVisualStyleBackColor = true;
            // 
            // DeleteCommandButton
            // 
            DeleteCommandButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            DeleteCommandButton.Location = new Point(259, 454);
            DeleteCommandButton.Margin = new Padding(3, 4, 3, 4);
            DeleteCommandButton.Name = "DeleteCommandButton";
            DeleteCommandButton.Size = new Size(102, 41);
            DeleteCommandButton.TabIndex = 9;
            DeleteCommandButton.Text = "Usuń";
            DeleteCommandButton.UseVisualStyleBackColor = true;
            // 
            // BotForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 562);
            Controls.Add(tabControl1);
            Margin = new Padding(3, 4, 3, 4);
            Name = "BotForm";
            Text = "Bot";
            tabControl1.ResumeLayout(false);
            CounterTabPage.ResumeLayout(false);
            CounterTabPage.PerformLayout();
            StatsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)statsDataGridView).EndInit();
            AccountSettingTabPage.ResumeLayout(false);
            AccountSettingTabPage.PerformLayout();
            CommandsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)CounterUserPermissionsDataGridView).EndInit();
            ((System.ComponentModel.ISupportInitialize)CommandsDataGridView).EndInit();
            LogsTabPage.ResumeLayout(false);
            ActivationTabPage.ResumeLayout(false);
            ActivationTabPage.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage CounterTabPage;
        private System.Windows.Forms.Button StartCounterButton;
        private System.Windows.Forms.Button StartBossButton;
        private System.Windows.Forms.Button StopCounterButton;
        private System.Windows.Forms.Button EndBossButton;
        private System.Windows.Forms.Button PauseBossButton;
        private System.Windows.Forms.RichTextBox BossNameTextBox;
        private System.Windows.Forms.Label CurrentBossLabel;
        private System.Windows.Forms.Label CounterStatusLabel;
        private System.Windows.Forms.Label BossStatusLabel;
        private System.Windows.Forms.Button ResetDeathsButton;
        private System.Windows.Forms.Button RemoveDeathButton;
        private System.Windows.Forms.Button AddDeathButton;
        private System.Windows.Forms.Button ResumeBossButton;
        private System.Windows.Forms.TabPage StatsTabPage;
        private System.Windows.Forms.DataGridView statsDataGridView;
        private System.Windows.Forms.TabPage AccountSettingTabPage;
        private System.Windows.Forms.Label TwitchAccountNameLabel;
        private System.Windows.Forms.RichTextBox TwitchAccountNameTextBox;
        private System.Windows.Forms.RichTextBox TwitchBotTokenTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox TwitchBotClientIDTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button SaveSettings;
        private System.Windows.Forms.TabPage CommandsTabPage;
        private System.Windows.Forms.DataGridView CommandsDataGridView;
        private System.Windows.Forms.TabPage LogsTabPage;
        private System.Windows.Forms.RichTextBox LoggingTextBox;
        private DataGridView CounterUserPermissionsDataGridView;
        private Button AddCommandButton;
        private Button AddUserPermissionButton;
        private RichTextBox CounterLogsTextBox;
        private TabPage ActivationTabPage;
        private Label BotStatusLabel;
        private Label label3;
        private Button TurnOffBotButton;
        private Button TurnOnBotButton;
        private RichTextBox CustomCounterTextBox;
        private Button SaveCustomBossCounterButton;
        private Label label6;
        private Label label5;
        private Button SaveCustomCounterButton;
        private Label label4;
        private RichTextBox CustomBossCounterTextBox;
        private Button DeleteBossStatButton;
        private Button AddBossStatsButton;
        private OpenFileDialog OpenAddBossStatForm;
        private Button ExportTxtButton;
        private Button ModifyBossStatButton;
        private Button DeleteUserPermissionsButton;
        private Button DeleteCommandButton;
    }
}

