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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.CounterTabPage = new System.Windows.Forms.TabPage();
            this.ResumeBossButton = new System.Windows.Forms.Button();
            this.ResetDeathsButton = new System.Windows.Forms.Button();
            this.RemoveDeathButton = new System.Windows.Forms.Button();
            this.AddDeathButton = new System.Windows.Forms.Button();
            this.BossStatusLabel = new System.Windows.Forms.Label();
            this.CurrentBossLabel = new System.Windows.Forms.Label();
            this.CounterStatusLabel = new System.Windows.Forms.Label();
            this.EndBossButton = new System.Windows.Forms.Button();
            this.PauseBossButton = new System.Windows.Forms.Button();
            this.BossNameTextBox = new System.Windows.Forms.RichTextBox();
            this.StartBossButton = new System.Windows.Forms.Button();
            this.StopCounterButton = new System.Windows.Forms.Button();
            this.StartCounterButton = new System.Windows.Forms.Button();
            this.StatsTabPage = new System.Windows.Forms.TabPage();
            this.statsDataGridView = new System.Windows.Forms.DataGridView();
            this.bossNameColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deathCounterColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timerColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccountSettingTabPage = new System.Windows.Forms.TabPage();
            this.SaveSettings = new System.Windows.Forms.Button();
            this.TwitchBotTokenTextBox = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.TwitchBotClientIDTextBox = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.TwitchAccountNameTextBox = new System.Windows.Forms.RichTextBox();
            this.TwitchAccountNameLabel = new System.Windows.Forms.Label();
            this.CommandsTabPage = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SaveCommandsButton = new System.Windows.Forms.Button();
            this.LogsTabPage = new System.Windows.Forms.TabPage();
            this.LoggingTextBox = new System.Windows.Forms.RichTextBox();
            this.tabControl1.SuspendLayout();
            this.CounterTabPage.SuspendLayout();
            this.StatsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statsDataGridView)).BeginInit();
            this.AccountSettingTabPage.SuspendLayout();
            this.CommandsTabPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.LogsTabPage.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.CounterTabPage);
            this.tabControl1.Controls.Add(this.StatsTabPage);
            this.tabControl1.Controls.Add(this.AccountSettingTabPage);
            this.tabControl1.Controls.Add(this.CommandsTabPage);
            this.tabControl1.Controls.Add(this.LogsTabPage);
            this.tabControl1.Location = new System.Drawing.Point(5, 5);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(793, 440);
            this.tabControl1.TabIndex = 0;
            // 
            // CounterTabPage
            // 
            this.CounterTabPage.Controls.Add(this.ResumeBossButton);
            this.CounterTabPage.Controls.Add(this.ResetDeathsButton);
            this.CounterTabPage.Controls.Add(this.RemoveDeathButton);
            this.CounterTabPage.Controls.Add(this.AddDeathButton);
            this.CounterTabPage.Controls.Add(this.BossStatusLabel);
            this.CounterTabPage.Controls.Add(this.CurrentBossLabel);
            this.CounterTabPage.Controls.Add(this.CounterStatusLabel);
            this.CounterTabPage.Controls.Add(this.EndBossButton);
            this.CounterTabPage.Controls.Add(this.PauseBossButton);
            this.CounterTabPage.Controls.Add(this.BossNameTextBox);
            this.CounterTabPage.Controls.Add(this.StartBossButton);
            this.CounterTabPage.Controls.Add(this.StopCounterButton);
            this.CounterTabPage.Controls.Add(this.StartCounterButton);
            this.CounterTabPage.Location = new System.Drawing.Point(4, 25);
            this.CounterTabPage.Name = "CounterTabPage";
            this.CounterTabPage.Padding = new System.Windows.Forms.Padding(3);
            this.CounterTabPage.Size = new System.Drawing.Size(785, 411);
            this.CounterTabPage.TabIndex = 0;
            this.CounterTabPage.Text = "Licznik";
            this.CounterTabPage.UseVisualStyleBackColor = true;
            // 
            // ResumeBossButton
            // 
            this.ResumeBossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResumeBossButton.Location = new System.Drawing.Point(416, 219);
            this.ResumeBossButton.Name = "ResumeBossButton";
            this.ResumeBossButton.Size = new System.Drawing.Size(164, 40);
            this.ResumeBossButton.TabIndex = 12;
            this.ResumeBossButton.Text = "Wznów bossa";
            this.ResumeBossButton.UseVisualStyleBackColor = true;
            this.ResumeBossButton.Click += new System.EventHandler(this.ResumeBossButton_Click);
            // 
            // ResetDeathsButton
            // 
            this.ResetDeathsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ResetDeathsButton.Location = new System.Drawing.Point(16, 278);
            this.ResetDeathsButton.Name = "ResetDeathsButton";
            this.ResetDeathsButton.Size = new System.Drawing.Size(250, 52);
            this.ResetDeathsButton.TabIndex = 11;
            this.ResetDeathsButton.Text = "Zresetuj śmierci";
            this.ResetDeathsButton.UseVisualStyleBackColor = true;
            this.ResetDeathsButton.Click += new System.EventHandler(this.ResetDeathsButton_Click);
            // 
            // RemoveDeathButton
            // 
            this.RemoveDeathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.RemoveDeathButton.Location = new System.Drawing.Point(16, 197);
            this.RemoveDeathButton.Name = "RemoveDeathButton";
            this.RemoveDeathButton.Size = new System.Drawing.Size(250, 52);
            this.RemoveDeathButton.TabIndex = 10;
            this.RemoveDeathButton.Text = "Odejmij śmierć";
            this.RemoveDeathButton.UseVisualStyleBackColor = true;
            this.RemoveDeathButton.Click += new System.EventHandler(this.RemoveDeathButton_Click);
            // 
            // AddDeathButton
            // 
            this.AddDeathButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.AddDeathButton.Location = new System.Drawing.Point(16, 121);
            this.AddDeathButton.Name = "AddDeathButton";
            this.AddDeathButton.Size = new System.Drawing.Size(250, 52);
            this.AddDeathButton.TabIndex = 9;
            this.AddDeathButton.Text = "Dodaj śmierć";
            this.AddDeathButton.UseVisualStyleBackColor = true;
            this.AddDeathButton.Click += new System.EventHandler(this.AddDeathButton_Click);
            // 
            // BossStatusLabel
            // 
            this.BossStatusLabel.AutoSize = true;
            this.BossStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.BossStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.BossStatusLabel.Location = new System.Drawing.Point(414, 371);
            this.BossStatusLabel.Name = "BossStatusLabel";
            this.BossStatusLabel.Size = new System.Drawing.Size(225, 20);
            this.BossStatusLabel.TabIndex = 8;
            this.BossStatusLabel.Text = "Status bossa: Nieaktywny";
            // 
            // CurrentBossLabel
            // 
            this.CurrentBossLabel.AutoSize = true;
            this.CurrentBossLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CurrentBossLabel.ForeColor = System.Drawing.Color.Red;
            this.CurrentBossLabel.Location = new System.Drawing.Point(414, 341);
            this.CurrentBossLabel.Name = "CurrentBossLabel";
            this.CurrentBossLabel.Size = new System.Drawing.Size(177, 20);
            this.CurrentBossLabel.TabIndex = 7;
            this.CurrentBossLabel.Text = "Aktualny boss: Brak";
            // 
            // CounterStatusLabel
            // 
            this.CounterStatusLabel.AutoSize = true;
            this.CounterStatusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.CounterStatusLabel.ForeColor = System.Drawing.Color.Red;
            this.CounterStatusLabel.Location = new System.Drawing.Point(33, 371);
            this.CounterStatusLabel.Name = "CounterStatusLabel";
            this.CounterStatusLabel.Size = new System.Drawing.Size(195, 20);
            this.CounterStatusLabel.TabIndex = 6;
            this.CounterStatusLabel.Text = "Naliczanie nieaktywne";
            // 
            // EndBossButton
            // 
            this.EndBossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.EndBossButton.Location = new System.Drawing.Point(598, 278);
            this.EndBossButton.Name = "EndBossButton";
            this.EndBossButton.Size = new System.Drawing.Size(164, 40);
            this.EndBossButton.TabIndex = 5;
            this.EndBossButton.Text = "Zakończ bossa";
            this.EndBossButton.UseVisualStyleBackColor = true;
            this.EndBossButton.Click += new System.EventHandler(this.EndBossButton_Click);
            // 
            // PauseBossButton
            // 
            this.PauseBossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.PauseBossButton.Location = new System.Drawing.Point(416, 278);
            this.PauseBossButton.Name = "PauseBossButton";
            this.PauseBossButton.Size = new System.Drawing.Size(164, 40);
            this.PauseBossButton.TabIndex = 4;
            this.PauseBossButton.Text = "Zatrzymaj bossa";
            this.PauseBossButton.UseVisualStyleBackColor = true;
            this.PauseBossButton.Click += new System.EventHandler(this.PauseBossButton_Click);
            // 
            // BossNameTextBox
            // 
            this.BossNameTextBox.Location = new System.Drawing.Point(418, 166);
            this.BossNameTextBox.Name = "BossNameTextBox";
            this.BossNameTextBox.Size = new System.Drawing.Size(344, 30);
            this.BossNameTextBox.TabIndex = 3;
            this.BossNameTextBox.Text = "";
            // 
            // StartBossButton
            // 
            this.StartBossButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartBossButton.Location = new System.Drawing.Point(598, 219);
            this.StartBossButton.Name = "StartBossButton";
            this.StartBossButton.Size = new System.Drawing.Size(164, 40);
            this.StartBossButton.TabIndex = 2;
            this.StartBossButton.Text = "Rozpocznij bossa";
            this.StartBossButton.UseVisualStyleBackColor = true;
            this.StartBossButton.Click += new System.EventHandler(this.StartBossButton_Click);
            // 
            // StopCounterButton
            // 
            this.StopCounterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StopCounterButton.Location = new System.Drawing.Point(16, 64);
            this.StopCounterButton.Name = "StopCounterButton";
            this.StopCounterButton.Size = new System.Drawing.Size(212, 39);
            this.StopCounterButton.TabIndex = 1;
            this.StopCounterButton.Text = "Zatrzymaj naliczanie";
            this.StopCounterButton.UseVisualStyleBackColor = true;
            this.StopCounterButton.Click += new System.EventHandler(this.StopCounterButton_Click);
            // 
            // StartCounterButton
            // 
            this.StartCounterButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.StartCounterButton.Location = new System.Drawing.Point(16, 17);
            this.StartCounterButton.Name = "StartCounterButton";
            this.StartCounterButton.Size = new System.Drawing.Size(212, 41);
            this.StartCounterButton.TabIndex = 0;
            this.StartCounterButton.Text = "Rozpocznij naliczanie";
            this.StartCounterButton.UseVisualStyleBackColor = true;
            this.StartCounterButton.Click += new System.EventHandler(this.StartCounterButton_Click);
            // 
            // StatsTabPage
            // 
            this.StatsTabPage.Controls.Add(this.statsDataGridView);
            this.StatsTabPage.Location = new System.Drawing.Point(4, 25);
            this.StatsTabPage.Name = "StatsTabPage";
            this.StatsTabPage.Size = new System.Drawing.Size(785, 411);
            this.StatsTabPage.TabIndex = 1;
            this.StatsTabPage.Text = "Stats";
            this.StatsTabPage.UseVisualStyleBackColor = true;
            // 
            // statsDataGridView
            // 
            this.statsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bossNameColumn,
            this.deathCounterColumn,
            this.timerColumn});
            this.statsDataGridView.Location = new System.Drawing.Point(3, 3);
            this.statsDataGridView.Name = "statsDataGridView";
            this.statsDataGridView.RowHeadersWidth = 51;
            this.statsDataGridView.RowTemplate.Height = 24;
            this.statsDataGridView.Size = new System.Drawing.Size(782, 405);
            this.statsDataGridView.TabIndex = 0;
            // 
            // bossNameColumn
            // 
            this.bossNameColumn.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.AllCells;
            this.bossNameColumn.FillWeight = 300F;
            this.bossNameColumn.HeaderText = "Nazwa Bossa";
            this.bossNameColumn.MinimumWidth = 6;
            this.bossNameColumn.Name = "bossNameColumn";
            this.bossNameColumn.Width = 119;
            // 
            // deathCounterColumn
            // 
            this.deathCounterColumn.HeaderText = "Liczba śmierci";
            this.deathCounterColumn.MinimumWidth = 6;
            this.deathCounterColumn.Name = "deathCounterColumn";
            this.deathCounterColumn.Width = 125;
            // 
            // timerColumn
            // 
            this.timerColumn.HeaderText = "Czas";
            this.timerColumn.MinimumWidth = 6;
            this.timerColumn.Name = "timerColumn";
            this.timerColumn.Width = 125;
            // 
            // AccountSettingTabPage
            // 
            this.AccountSettingTabPage.Controls.Add(this.SaveSettings);
            this.AccountSettingTabPage.Controls.Add(this.TwitchBotTokenTextBox);
            this.AccountSettingTabPage.Controls.Add(this.label2);
            this.AccountSettingTabPage.Controls.Add(this.TwitchBotClientIDTextBox);
            this.AccountSettingTabPage.Controls.Add(this.label1);
            this.AccountSettingTabPage.Controls.Add(this.TwitchAccountNameTextBox);
            this.AccountSettingTabPage.Controls.Add(this.TwitchAccountNameLabel);
            this.AccountSettingTabPage.Location = new System.Drawing.Point(4, 25);
            this.AccountSettingTabPage.Name = "AccountSettingTabPage";
            this.AccountSettingTabPage.Size = new System.Drawing.Size(785, 411);
            this.AccountSettingTabPage.TabIndex = 2;
            this.AccountSettingTabPage.Text = "Ustawienia konta";
            this.AccountSettingTabPage.UseVisualStyleBackColor = true;
            // 
            // SaveSettings
            // 
            this.SaveSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveSettings.Location = new System.Drawing.Point(19, 361);
            this.SaveSettings.Name = "SaveSettings";
            this.SaveSettings.Size = new System.Drawing.Size(132, 33);
            this.SaveSettings.TabIndex = 6;
            this.SaveSettings.Text = "Zapisz ustawienia";
            this.SaveSettings.UseVisualStyleBackColor = true;
            // 
            // TwitchBotTokenTextBox
            // 
            this.TwitchBotTokenTextBox.Location = new System.Drawing.Point(19, 198);
            this.TwitchBotTokenTextBox.Name = "TwitchBotTokenTextBox";
            this.TwitchBotTokenTextBox.Size = new System.Drawing.Size(395, 27);
            this.TwitchBotTokenTextBox.TabIndex = 5;
            this.TwitchBotTokenTextBox.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(15, 173);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 22);
            this.label2.TabIndex = 4;
            this.label2.Text = "Twitch Bot Token";
            // 
            // TwitchBotClientIDTextBox
            // 
            this.TwitchBotClientIDTextBox.Location = new System.Drawing.Point(19, 112);
            this.TwitchBotClientIDTextBox.Name = "TwitchBotClientIDTextBox";
            this.TwitchBotClientIDTextBox.Size = new System.Drawing.Size(395, 27);
            this.TwitchBotClientIDTextBox.TabIndex = 3;
            this.TwitchBotClientIDTextBox.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(15, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(173, 22);
            this.label1.TabIndex = 2;
            this.label1.Text = "Twitch Bot Client ID ";
            // 
            // TwitchAccountNameTextBox
            // 
            this.TwitchAccountNameTextBox.Location = new System.Drawing.Point(19, 39);
            this.TwitchAccountNameTextBox.Name = "TwitchAccountNameTextBox";
            this.TwitchAccountNameTextBox.Size = new System.Drawing.Size(395, 27);
            this.TwitchAccountNameTextBox.TabIndex = 1;
            this.TwitchAccountNameTextBox.Text = "";
            // 
            // TwitchAccountNameLabel
            // 
            this.TwitchAccountNameLabel.AutoSize = true;
            this.TwitchAccountNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.TwitchAccountNameLabel.Location = new System.Drawing.Point(15, 14);
            this.TwitchAccountNameLabel.Name = "TwitchAccountNameLabel";
            this.TwitchAccountNameLabel.Size = new System.Drawing.Size(173, 22);
            this.TwitchAccountNameLabel.TabIndex = 0;
            this.TwitchAccountNameLabel.Text = "Nazwa kanału twitch";
            // 
            // CommandsTabPage
            // 
            this.CommandsTabPage.Controls.Add(this.dataGridView1);
            this.CommandsTabPage.Controls.Add(this.SaveCommandsButton);
            this.CommandsTabPage.Location = new System.Drawing.Point(4, 25);
            this.CommandsTabPage.Name = "CommandsTabPage";
            this.CommandsTabPage.Size = new System.Drawing.Size(785, 411);
            this.CommandsTabPage.TabIndex = 3;
            this.CommandsTabPage.Text = "Komendy";
            this.CommandsTabPage.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(18, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(748, 344);
            this.dataGridView1.TabIndex = 3;
            // 
            // SaveCommandsButton
            // 
            this.SaveCommandsButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.SaveCommandsButton.Location = new System.Drawing.Point(18, 363);
            this.SaveCommandsButton.Name = "SaveCommandsButton";
            this.SaveCommandsButton.Size = new System.Drawing.Size(102, 33);
            this.SaveCommandsButton.TabIndex = 2;
            this.SaveCommandsButton.Text = "Zapisz";
            this.SaveCommandsButton.UseVisualStyleBackColor = true;
            // 
            // LogsTabPage
            // 
            this.LogsTabPage.Controls.Add(this.LoggingTextBox);
            this.LogsTabPage.Location = new System.Drawing.Point(4, 25);
            this.LogsTabPage.Name = "LogsTabPage";
            this.LogsTabPage.Size = new System.Drawing.Size(785, 411);
            this.LogsTabPage.TabIndex = 4;
            this.LogsTabPage.Text = "Logi";
            this.LogsTabPage.UseVisualStyleBackColor = true;
            // 
            // LoggingTextBox
            // 
            this.LoggingTextBox.Location = new System.Drawing.Point(3, 3);
            this.LoggingTextBox.Name = "LoggingTextBox";
            this.LoggingTextBox.Size = new System.Drawing.Size(779, 405);
            this.LoggingTextBox.TabIndex = 0;
            this.LoggingTextBox.Text = "";
            this.LoggingTextBox.TextChanged += new System.EventHandler(this.LoggingTextBox_TextChanged);
            // 
            // BotForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "BotForm";
            this.Text = "Bot";
            this.tabControl1.ResumeLayout(false);
            this.CounterTabPage.ResumeLayout(false);
            this.CounterTabPage.PerformLayout();
            this.StatsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.statsDataGridView)).EndInit();
            this.AccountSettingTabPage.ResumeLayout(false);
            this.AccountSettingTabPage.PerformLayout();
            this.CommandsTabPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.LogsTabPage.ResumeLayout(false);
            this.ResumeLayout(false);

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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button SaveCommandsButton;
        private System.Windows.Forms.TabPage LogsTabPage;
        private System.Windows.Forms.RichTextBox LoggingTextBox;
    }
}

