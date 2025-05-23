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
    public partial class MenuForm : Form
    {
        public MenuForm()
        {
            InitializeComponent();
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            AdditemForm additem = new AdditemForm();
            additem.Show();
            this.Hide();
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DeleteEventForm deleteevent = new DeleteEventForm();
            deleteevent.Show();
            this.Hide();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewEventForm viewform = new ViewEventForm();
            viewform.Show();
            this.Hide();
        }

        private void Viewfeedbacklabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            ViewFeedbackForm viewfeed = new ViewFeedbackForm();
            viewfeed.Show();
            this.Hide();
        }

        private void admindashboardlinkLabel_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            AdminDashboardForm viewdash = new AdminDashboardForm();
            viewdash.Show();
            this.Hide();
        }
    }
}
