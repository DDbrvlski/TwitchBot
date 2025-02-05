using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TwitchBot.Views
{
    public partial class EditBossStatForm : Form
    {
        public string BossName { get; private set; }
        public int NumberOfDeaths { get; private set; }
        public string Time { get; private set; }

        private string bossNamePlaceholder = "Nazwa bossa";
        private string numberOfDeathsPlaceholder = "Liczba śmierci";
        private string timePlaceholder = "Czas (hh:mm:ss)";



        public EditBossStatForm()
        {
            InitializeComponent();
            SetPlaceholders();
            SetTexboxesFocus();
        }

        private void SetTexboxesFocus()
        {
            BossNameTextBox.GotFocus += BossNameTextBox_GotFocus;
            BossNameTextBox.LostFocus += BossNameTextBox_LostFocus;

            BossTimeTextBox.GotFocus += BossTimeTextBox_GotFocus;
            BossTimeTextBox.LostFocus += BossTimeTextBox_LostFocus;

            NumberOfDeathsTextBox.GotFocus += NumberOfDeathsTextBox_GotFocus;
            NumberOfDeathsTextBox.LostFocus += NumberOfDeathsTextBox_LostFocus;
        }

        private void NumberOfDeathsTextBox_LostFocus(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(NumberOfDeathsTextBox.Text))
            {
                SetNumberOfDeathsPlaceholder();
            }
        }

        private void NumberOfDeathsTextBox_GotFocus(object? sender, EventArgs e)
        {
            if (NumberOfDeathsTextBox.Text == numberOfDeathsPlaceholder)
            {
                NumberOfDeathsTextBox.Text = "";
                NumberOfDeathsTextBox.ForeColor = Color.Black;
            }
        }

        private void BossTimeTextBox_LostFocus(object? sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BossTimeTextBox.Text))
            {
                SetBossTimePlaceholder();
            }
        }

        private void BossTimeTextBox_GotFocus(object? sender, EventArgs e)
        {
            if (BossTimeTextBox.Text == timePlaceholder)
            {
                BossTimeTextBox.Text = "";
                BossTimeTextBox.ForeColor = Color.Black;
            }
        }

        private void BossNameTextBox_GotFocus(object sender, EventArgs e)
        {
            if (BossNameTextBox.Text == bossNamePlaceholder)
            {
                BossNameTextBox.Text = "";
                BossNameTextBox.ForeColor = Color.Black;
            }
        }

        private void BossNameTextBox_LostFocus(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(BossNameTextBox.Text))
            {
                SetBossNamePlaceholder();
            }
        }
        private void SetPlaceholders()
        {
            SetBossNamePlaceholder();
            SetBossTimePlaceholder();
            SetNumberOfDeathsPlaceholder();
        }

        private void SetBossNamePlaceholder()
        {
            BossNameTextBox.Text = bossNamePlaceholder;
            BossNameTextBox.ForeColor = Color.Gray;
        }

        private void SetNumberOfDeathsPlaceholder()
        {
            NumberOfDeathsTextBox.Text = numberOfDeathsPlaceholder;
            NumberOfDeathsTextBox.ForeColor = Color.Gray;
        }

        private void SetBossTimePlaceholder()
        {
            BossTimeTextBox.Text = timePlaceholder;
            BossTimeTextBox.ForeColor = Color.Gray;
        }

        private void SaveBossStatButton_Click(object sender, EventArgs e)
        {
            BossName = BossNameTextBox.Text;
            NumberOfDeaths = int.Parse(NumberOfDeathsTextBox.Text); 
            Time = BossTimeTextBox.Text;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}
