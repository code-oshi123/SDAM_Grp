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
    public partial class AdditemForm : Form
    {
        public AdditemForm()
        {
            InitializeComponent();
        }

        private void addevntbutton_Click(object sender, EventArgs e)
        {
            MessageBox.Show(EventconClass.AddEvent(eidtextBox.Text, enametextBox.Text, edestextBox.Text, edateTimePicker.Value, eloctextBox.Text));
            //datetextBox.Text
        }

        private void BackTobutton_Click(object sender, EventArgs e)
        {
            MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Hide();
        }
    }
}
