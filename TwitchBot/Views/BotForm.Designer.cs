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
            statsDataGridView = new DataGridView();
            bossNameColumn = new DataGridViewTextBoxColumn();
            deathCounterColumn = new DataGridViewTextBoxColumn();
            timerColumn = new DataGridViewTextBoxColumn();
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
            SaveUserPermissionsButton = new Button();
            CounterUserPermissionsDataGridView = new DataGridView();
            CommandsDataGridView = new DataGridView();
            SaveCommandsButton = new Button();
            LogsTabPage = new TabPage();
            LoggingTextBox = new RichTextBox();
            CounterLogsTextBox = new RichTextBox();
            tabControl1.SuspendLayout();
            CounterTabPage.SuspendLayout();
            StatsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)statsDataGridView).BeginInit();
            AccountSettingTabPage.SuspendLayout();
            CommandsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)CounterUserPermissionsDataGridView).BeginInit();
            ((System.ComponentModel.ISupportInitialize)CommandsDataGridView).BeginInit();
            LogsTabPage.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(CounterTabPage);
            tabControl1.Controls.Add(StatsTabPage);
            tabControl1.Controls.Add(AccountSettingTabPage);
            tabControl1.Controls.Add(CommandsTabPage);
            tabControl1.Controls.Add(LogsTabPage);
            tabControl1.Location = new Point(5, 6);
            tabControl1.Margin = new Padding(3, 4, 3, 4);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(793, 550);
            tabControl1.TabIndex = 0;
            // 
            // CounterTabPage
            // 
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
            // ResumeBossButton
            // 
            ResumeBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            ResumeBossButton.Location = new Point(416, 274);
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
            ResetDeathsButton.Location = new Point(16, 348);
            ResetDeathsButton.Margin = new Padding(3, 4, 3, 4);
            ResetDeathsButton.Name = "ResetDeathsButton";
            ResetDeathsButton.Size = new Size(250, 65);
            ResetDeathsButton.TabIndex = 11;
            ResetDeathsButton.Text = "Zresetuj śmierci";
            ResetDeathsButton.UseVisualStyleBackColor = true;
            ResetDeathsButton.Click += ResetDeathsButton_Click;
            // 
            // RemoveDeathButton
            // 
            RemoveDeathButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            RemoveDeathButton.Location = new Point(16, 246);
            RemoveDeathButton.Margin = new Padding(3, 4, 3, 4);
            RemoveDeathButton.Name = "RemoveDeathButton";
            RemoveDeathButton.Size = new Size(250, 65);
            RemoveDeathButton.TabIndex = 10;
            RemoveDeathButton.Text = "Odejmij śmierć";
            RemoveDeathButton.UseVisualStyleBackColor = true;
            RemoveDeathButton.Click += RemoveDeathButton_Click;
            // 
            // AddDeathButton
            // 
            AddDeathButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            AddDeathButton.Location = new Point(16, 151);
            AddDeathButton.Margin = new Padding(3, 4, 3, 4);
            AddDeathButton.Name = "AddDeathButton";
            AddDeathButton.Size = new Size(250, 65);
            AddDeathButton.TabIndex = 9;
            AddDeathButton.Text = "Dodaj śmierć";
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
            CurrentBossLabel.Location = new Point(414, 426);
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
            CounterStatusLabel.Location = new Point(33, 464);
            CounterStatusLabel.Name = "CounterStatusLabel";
            CounterStatusLabel.Size = new Size(195, 20);
            CounterStatusLabel.TabIndex = 6;
            CounterStatusLabel.Text = "Naliczanie nieaktywne";
            // 
            // EndBossButton
            // 
            EndBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            EndBossButton.Location = new Point(598, 348);
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
            PauseBossButton.Location = new Point(416, 348);
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
            BossNameTextBox.Location = new Point(418, 208);
            BossNameTextBox.Margin = new Padding(3, 4, 3, 4);
            BossNameTextBox.Name = "BossNameTextBox";
            BossNameTextBox.Size = new Size(344, 36);
            BossNameTextBox.TabIndex = 3;
            BossNameTextBox.Text = "";
            // 
            // StartBossButton
            // 
            StartBossButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartBossButton.Location = new Point(598, 274);
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
            StopCounterButton.Location = new Point(16, 80);
            StopCounterButton.Margin = new Padding(3, 4, 3, 4);
            StopCounterButton.Name = "StopCounterButton";
            StopCounterButton.Size = new Size(212, 49);
            StopCounterButton.TabIndex = 1;
            StopCounterButton.Text = "Zatrzymaj naliczanie";
            StopCounterButton.UseVisualStyleBackColor = true;
            StopCounterButton.Click += StopCounterButton_Click;
            // 
            // StartCounterButton
            // 
            StartCounterButton.Font = new Font("Microsoft Sans Serif", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            StartCounterButton.Location = new Point(16, 21);
            StartCounterButton.Margin = new Padding(3, 4, 3, 4);
            StartCounterButton.Name = "StartCounterButton";
            StartCounterButton.Size = new Size(212, 51);
            StartCounterButton.TabIndex = 0;
            StartCounterButton.Text = "Rozpocznij naliczanie";
            StartCounterButton.UseVisualStyleBackColor = true;
            StartCounterButton.Click += StartCounterButton_Click;
            // 
            // StatsTabPage
            // 
            StatsTabPage.Controls.Add(statsDataGridView);
            StatsTabPage.Location = new Point(4, 29);
            StatsTabPage.Margin = new Padding(3, 4, 3, 4);
            StatsTabPage.Name = "StatsTabPage";
            StatsTabPage.Size = new Size(785, 517);
            StatsTabPage.TabIndex = 1;
            StatsTabPage.Text = "Stats";
            StatsTabPage.UseVisualStyleBackColor = true;
            // 
            // statsDataGridView
            // 
            statsDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            statsDataGridView.Columns.AddRange(new DataGridViewColumn[] { bossNameColumn, deathCounterColumn, timerColumn });
            statsDataGridView.Location = new Point(3, 4);
            statsDataGridView.Margin = new Padding(3, 4, 3, 4);
            statsDataGridView.Name = "statsDataGridView";
            statsDataGridView.RowHeadersWidth = 51;
            statsDataGridView.RowTemplate.Height = 24;
            statsDataGridView.Size = new Size(782, 506);
            statsDataGridView.TabIndex = 0;
            // 
            // bossNameColumn
            // 
            bossNameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            bossNameColumn.FillWeight = 300F;
            bossNameColumn.HeaderText = "Nazwa Bossa";
            bossNameColumn.MinimumWidth = 6;
            bossNameColumn.Name = "bossNameColumn";
            bossNameColumn.Width = 125;
            // 
            // deathCounterColumn
            // 
            deathCounterColumn.HeaderText = "Liczba śmierci";
            deathCounterColumn.MinimumWidth = 6;
            deathCounterColumn.Name = "deathCounterColumn";
            deathCounterColumn.Width = 125;
            // 
            // timerColumn
            // 
            timerColumn.HeaderText = "Czas";
            timerColumn.MinimumWidth = 6;
            timerColumn.Name = "timerColumn";
            timerColumn.Width = 125;
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
            CommandsTabPage.Controls.Add(AddUserPermissionButton);
            CommandsTabPage.Controls.Add(AddCommandButton);
            CommandsTabPage.Controls.Add(SaveUserPermissionsButton);
            CommandsTabPage.Controls.Add(CounterUserPermissionsDataGridView);
            CommandsTabPage.Controls.Add(CommandsDataGridView);
            CommandsTabPage.Controls.Add(SaveCommandsButton);
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
            AddUserPermissionButton.Location = new Point(538, 454);
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
            AddCommandButton.Location = new Point(136, 454);
            AddCommandButton.Margin = new Padding(3, 4, 3, 4);
            AddCommandButton.Name = "AddCommandButton";
            AddCommandButton.Size = new Size(102, 41);
            AddCommandButton.TabIndex = 6;
            AddCommandButton.Text = "Dodaj";
            AddCommandButton.UseVisualStyleBackColor = true;
            // 
            // SaveUserPermissionsButton
            // 
            SaveUserPermissionsButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SaveUserPermissionsButton.Location = new Point(418, 454);
            SaveUserPermissionsButton.Margin = new Padding(3, 4, 3, 4);
            SaveUserPermissionsButton.Name = "SaveUserPermissionsButton";
            SaveUserPermissionsButton.Size = new Size(102, 41);
            SaveUserPermissionsButton.TabIndex = 5;
            SaveUserPermissionsButton.Text = "Zapisz";
            SaveUserPermissionsButton.UseVisualStyleBackColor = true;
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
            CounterUserPermissionsDataGridView.CellContentClick += CounterUserPermissionsDataGridView_CellContentClick;
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
            // SaveCommandsButton
            // 
            SaveCommandsButton.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            SaveCommandsButton.Location = new Point(18, 454);
            SaveCommandsButton.Margin = new Padding(3, 4, 3, 4);
            SaveCommandsButton.Name = "SaveCommandsButton";
            SaveCommandsButton.Size = new Size(102, 41);
            SaveCommandsButton.TabIndex = 2;
            SaveCommandsButton.Text = "Zapisz";
            SaveCommandsButton.UseVisualStyleBackColor = true;
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
            LoggingTextBox.TextChanged += LoggingTextBox_TextChanged;
            // 
            // CounterLogsTextBox
            // 
            CounterLogsTextBox.Location = new Point(341, 21);
            CounterLogsTextBox.Margin = new Padding(3, 4, 3, 4);
            CounterLogsTextBox.Name = "CounterLogsTextBox";
            CounterLogsTextBox.Size = new Size(421, 166);
            CounterLogsTextBox.TabIndex = 13;
            CounterLogsTextBox.Text = "";
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
        private System.Windows.Forms.DataGridViewTextBoxColumn bossNameColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn deathCounterColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn timerColumn;
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
        private System.Windows.Forms.Button SaveCommandsButton;
        private System.Windows.Forms.TabPage LogsTabPage;
        private System.Windows.Forms.RichTextBox LoggingTextBox;
        private Button SaveUserPermissionsButton;
        private DataGridView CounterUserPermissionsDataGridView;
        private Button AddCommandButton;
        private Button AddUserPermissionButton;
        private RichTextBox CounterLogsTextBox;
    }
}

