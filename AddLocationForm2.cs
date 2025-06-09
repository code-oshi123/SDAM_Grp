using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbex
{
    public partial class AddLocationForm2 : Form
    {
        public AddLocationForm2()
        {
            InitializeComponent();
        }

        private void addlocadbutton1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(AdminConClass.AddLoc(locnameaddtextBox.Text, locadressaddtextBox.Text, locowneraddtextBox.Text));
            locnameaddtextBox.Clear();
            locadressaddtextBox.Clear();
            locowneraddtextBox.Clear();

        }

        private void addlocbackbutton2_Click(object sender, EventArgs e)
        {
            AdminDashboardForm adminDashboardForm = new AdminDashboardForm();
            adminDashboardForm.Show();
            this.Hide();
        }
    }
}
