namespace TwitchBot.Views
{
    partial class EditBossStatForm
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
            BossTimeTextBox = new RichTextBox();
            NumberOfDeathsTextBox = new RichTextBox();
            BossNameTextBox = new RichTextBox();
            SaveBossStatButton = new Button();
            SuspendLayout();
            // 
            // BossTimeTextBox
            // 
            BossTimeTextBox.Location = new Point(12, 120);
            BossTimeTextBox.Name = "BossTimeTextBox";
            BossTimeTextBox.Size = new Size(272, 32);
            BossTimeTextBox.TabIndex = 7;
            BossTimeTextBox.Text = "Czas (hh:mm:ss)";
            // 
            // NumberOfDeathsTextBox
            // 
            NumberOfDeathsTextBox.Location = new Point(12, 67);
            NumberOfDeathsTextBox.Name = "NumberOfDeathsTextBox";
            NumberOfDeathsTextBox.Size = new Size(272, 32);
            NumberOfDeathsTextBox.TabIndex = 6;
            NumberOfDeathsTextBox.Text = "Ilość śmierci";
            // 
            // BossNameTextBox
            // 
            BossNameTextBox.Location = new Point(12, 12);
            BossNameTextBox.Name = "BossNameTextBox";
            BossNameTextBox.Size = new Size(272, 32);
            BossNameTextBox.TabIndex = 5;
            BossNameTextBox.Text = "Nazwa bossa";
            // 
            // SaveBossStatButton
            // 
            SaveBossStatButton.Location = new Point(78, 173);
            SaveBossStatButton.Name = "SaveBossStatButton";
            SaveBossStatButton.Size = new Size(134, 40);
            SaveBossStatButton.TabIndex = 4;
            SaveBossStatButton.Text = "Zapisz";
            SaveBossStatButton.UseVisualStyleBackColor = true;
            SaveBossStatButton.Click += SaveBossStatButton_Click;
            // 
            // EditBossStatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 230);
            Controls.Add(BossTimeTextBox);
            Controls.Add(NumberOfDeathsTextBox);
            Controls.Add(BossNameTextBox);
            Controls.Add(SaveBossStatButton);
            Name = "EditBossStatForm";
            Text = "EditBossStatForm";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox BossTimeTextBox;
        private RichTextBox NumberOfDeathsTextBox;
        private RichTextBox BossNameTextBox;
        private Button SaveBossStatButton;
    }
}