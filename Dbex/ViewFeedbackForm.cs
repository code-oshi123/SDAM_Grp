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
    public partial class ViewFeedbackForm : Form
    {
        public ViewFeedbackForm()
        {
            InitializeComponent();
        }

        private void feedbackbacktomenubtn_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }

        private void viewfeeedbackbtn_Click(object sender, EventArgs e)
        {
            var feedbacks = ReviewConClass.Viewfeedback();

            if (feedbacks == null)
            {
                MessageBox.Show("Failed to load items from database");
                return;
            }

            if (feedbacks.Count == 0)
            {
                MessageBox.Show("No items found in database");
                return;
            }

            // Clear and populate ListBox
            Feedbackviewlistbox.Items.Clear();
            Feedbackviewlistbox.Items.Add(" Index|Event ID|Event Name|Event Feedback");
            Feedbackviewlistbox.Items.Add("-------------------------------------------------------------");
            Feedbackviewlistbox.Items.AddRange(feedbacks.ToArray());

            MessageBox.Show($"Loaded {feedbacks.Count} items");
        }
    }
}
