namespace TwitchBot.Views
{
    partial class AddBossStatForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            SaveBossStatButton = new Button();
            BossNameTextBox = new RichTextBox();
            NumberOfDeathsTextBox = new RichTextBox();
            BossTimeTextBox = new RichTextBox();
            SuspendLayout();
            // 
            // SaveBossStatButton
            // 
            SaveBossStatButton.Location = new Point(78, 186);
            SaveBossStatButton.Name = "SaveBossStatButton";
            SaveBossStatButton.Size = new Size(134, 40);
            SaveBossStatButton.TabIndex = 0;
            SaveBossStatButton.Text = "Zapisz";
            SaveBossStatButton.UseVisualStyleBackColor = true;
            SaveBossStatButton.Click += SaveBossStatButton_Click;
            // 
            // BossNameTextBox
            // 
            BossNameTextBox.Location = new Point(12, 25);
            BossNameTextBox.Name = "BossNameTextBox";
            BossNameTextBox.Size = new Size(272, 32);
            BossNameTextBox.TabIndex = 1;
            BossNameTextBox.Text = "Nazwa bossa";
            // 
            // NumberOfDeathsTextBox
            // 
            NumberOfDeathsTextBox.Location = new Point(12, 80);
            NumberOfDeathsTextBox.Name = "NumberOfDeathsTextBox";
            NumberOfDeathsTextBox.Size = new Size(272, 32);
            NumberOfDeathsTextBox.TabIndex = 2;
            NumberOfDeathsTextBox.Text = "Ilość śmierci";
            // 
            // BossTimeTextBox
            // 
            BossTimeTextBox.Location = new Point(12, 133);
            BossTimeTextBox.Name = "BossTimeTextBox";
            BossTimeTextBox.Size = new Size(272, 32);
            BossTimeTextBox.TabIndex = 3;
            BossTimeTextBox.Text = "Czas (hh:mm:ss)";
            // 
            // AddBossStatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(297, 238);
            Controls.Add(BossTimeTextBox);
            Controls.Add(NumberOfDeathsTextBox);
            Controls.Add(BossNameTextBox);
            Controls.Add(SaveBossStatButton);
            Name = "AddBossStatForm";
            Text = "Dodaj bossa";
            ResumeLayout(false);
        }

        #endregion

        private Button SaveBossStatButton;
        private RichTextBox BossNameTextBox;
        private RichTextBox NumberOfDeathsTextBox;
        private RichTextBox BossTimeTextBox;
    }
}