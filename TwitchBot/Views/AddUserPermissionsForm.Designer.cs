namespace TwitchBot.Views
{
    partial class AddUserPermissionsForm
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
            UsernameTextBox = new RichTextBox();
            CommandCategoriesComboBox = new ComboBox();
            SaveUserPermissionsButton = new Button();
            SuspendLayout();
            // 
            // UsernameTextBox
            // 
            UsernameTextBox.Location = new Point(11, 12);
            UsernameTextBox.Name = "UsernameTextBox";
            UsernameTextBox.Size = new Size(272, 32);
            UsernameTextBox.TabIndex = 2;
            UsernameTextBox.Text = "Nazwa użytkownika";
            // 
            // CommandCategoriesComboBox
            // 
            CommandCategoriesComboBox.FormattingEnabled = true;
            CommandCategoriesComboBox.Location = new Point(11, 65);
            CommandCategoriesComboBox.Name = "CommandCategoriesComboBox";
            CommandCategoriesComboBox.Size = new Size(272, 28);
            CommandCategoriesComboBox.TabIndex = 3;
            // 
            // SaveUserPermissionsButton
            // 
            SaveUserPermissionsButton.Location = new Point(79, 118);
            SaveUserPermissionsButton.Name = "SaveUserPermissionsButton";
            SaveUserPermissionsButton.Size = new Size(134, 40);
            SaveUserPermissionsButton.TabIndex = 4;
            SaveUserPermissionsButton.Text = "Zapisz";
            SaveUserPermissionsButton.UseVisualStyleBackColor = true;
            SaveUserPermissionsButton.Click += SaveUserPermissionsButton_Click;
            // 
            // AddUserPermissionsForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(295, 176);
            Controls.Add(SaveUserPermissionsButton);
            Controls.Add(CommandCategoriesComboBox);
            Controls.Add(UsernameTextBox);
            Name = "AddUserPermissionsForm";
            Text = "Dodaj użytkownika";
            ResumeLayout(false);
        }

        #endregion

        private RichTextBox UsernameTextBox;
        private ComboBox CommandCategoriesComboBox;
        private Button SaveUserPermissionsButton;
    }
}