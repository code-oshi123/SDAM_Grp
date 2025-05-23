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
    public partial class ViewEventForm : Form
    {
        public ViewEventForm()
        {
            InitializeComponent();
        }

        private void Vieeventbutton_Click(object sender, EventArgs e)
        {
            var items = EventconClass.ViewEvents();

            if (items == null)
            {
                MessageBox.Show("Failed to load items from database");
                return;
            }

            if (items.Count == 0)
            {
                MessageBox.Show("No items found in database");
                return;
            }

            // Clear and populate ListBox
            ViewEventlistBox.Items.Clear();
            ViewEventlistBox.Items.AddRange(items.ToArray());
            MessageBox.Show($"Loaded {items.Count} items");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MenuForm menu = new MenuForm();
            menu.Show();
            this.Hide();
        }
    }
}
