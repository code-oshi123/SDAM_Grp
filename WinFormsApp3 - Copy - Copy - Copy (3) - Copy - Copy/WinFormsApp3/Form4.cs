using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsApp3.Controller;

namespace WinFormsApp3
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        private void btnLoadTickets_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtEventID.Text, out int eventID))
            {
                MessageBox.Show("Please enter a valid numeric Event ID.");
                return;
            }

            if (string.IsNullOrEmpty(cmbTicketType.SelectedItem?.ToString()))
            {
                MessageBox.Show("Please select a ticket type.");
                return;
            }

            if (!int.TryParse(txtQuantity.Text, out int quantity) || quantity <= 0)
            {
                MessageBox.Show("Please enter a valid quantity.");
                return;
            }

            string selectedType = cmbTicketType.SelectedItem.ToString();

            TicketController controller = new TicketController();
            if (!controller.EventIDExists(eventID))
            {
                MessageBox.Show("Event ID does not exist.");
                return;
            }

            decimal? price = controller.GetTicketPriceByEventAndType(eventID, selectedType);
            if (price.HasValue)
            {
                lblPrice.Text = $"Price: ${price.Value}";
                decimal total = price.Value * quantity;
                lblTotal.Text = $"Total: ${total}";
            }
            else
            {
                lblPrice.Text = "Price not found.";
                lblTotal.Text = "Total: N/A";
            }
        }




    }
}
