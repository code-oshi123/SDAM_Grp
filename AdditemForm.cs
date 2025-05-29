
﻿using System;
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
            MessageBox.Show(EventconClass.AddEvent(eidtextBox.Text, organizeridevtextBox1.Text,enametextBox.Text, edestextBox.Text, edateTimePicker.Value, eventtimetextBox2.Text, eloctextBox.Text));
            //datetextBox.Text
        }

        private void BackTobutton_Click(object sender, EventArgs e)
        {
            OrganizerMenuEventForm ormenuForm = new OrganizerMenuEventForm();
            ormenuForm.Show();
            this.Hide();
        }

        private void vieweventgobutton_Click(object sender, EventArgs e)
        {
            AdminevviewForm newview = new AdminevviewForm();
            newview.Show();
            this.Hide();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

