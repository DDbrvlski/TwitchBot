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
    public partial class AddUserPermissionsForm : Form
    {
        private List<string> categories;
        private string selectedCategory;

        public AddUserPermissionsForm(List<string> categories)
        {
            InitializeComponent();
            this.categories = categories;
        }

        private void BindDataToCategoriesComboBox()
        {
            CommandCategoriesComboBox.DataSource = categories;
        }

        

        private void SaveUserPermissionsButton_Click(object sender, EventArgs e)
        {

        }
    }
}
