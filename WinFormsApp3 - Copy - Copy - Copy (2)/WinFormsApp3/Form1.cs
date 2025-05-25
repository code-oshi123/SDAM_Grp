using WinFormsApp3.Controller;
using WinFormsApp3.Models;
namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        private TicketController ticketController = new TicketController();
        public Form1()
        {
            InitializeComponent();
            btnUpdatePrice.Click += btnUpdatePrice_Click;
            btnDeleteTicket.Click += btnDeleteTicket_Click;
            btnViewTickets.Click += btnViewTickets_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewTickets.ColumnCount = 5;
            dataGridViewTickets.Columns[0].Name = "Ticket ID";
            dataGridViewTickets.Columns[1].Name = "Event ID";
            dataGridViewTickets.Columns[2].Name = "Type";
            dataGridViewTickets.Columns[3].Name = "Price";
            dataGridViewTickets.Columns[4].Name = "Availability";
        }
        private void RefreshTicketList()
        {
            dataGridViewTickets.Rows.Clear();

            foreach (var ticket in ticketController.GetAllTickets())
            {
                dataGridViewTickets.Rows.Add(ticket.TicketID, ticket.EventID, ticket.Type, ticket.Price, ticket.Availability);
            }
        }


        private void btnAddTicket_Click(object sender, EventArgs e)
        {
            try
            {
                int eventId = int.Parse(txtEventID.Text);
                string type = txtType.Text;
                decimal price = decimal.Parse(txtPrice.Text);
                int availability = int.Parse(txtAvailability.Text);

                ticketController.AddTicket(eventId, type, price, availability);

                RefreshTicketList(); // reload updated data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void btnUpdatePrice_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtUpdateTicketID.Text, out int ticketID))
            {
                MessageBox.Show("Please enter a valid Ticket ID.");
                return;
            }

            if (!decimal.TryParse(txtNewPrice.Text, out decimal newPrice))
            {
                MessageBox.Show("Please enter a valid new price.");
                return;
            }

            string result = ticketController.UpdateTicketPrice(ticketID, newPrice);
            MessageBox.Show(result); // This shows "Ticket not found." if it's invalid
            RefreshTicketList();
        }

        private void btnDeleteTicket_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtDeleteTicketID.Text.Trim(), out int ticketID))
            {
                MessageBox.Show("Please enter a valid Ticket ID.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                bool success = ticketController.DeleteTicket(ticketID);

                if (success)
                {
                    MessageBox.Show("Ticket deleted successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    RefreshTicketList();
                }
                else
                {
                    MessageBox.Show("Ticket not found in the database.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while deleting the ticket:\n" + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            RefreshTicketList(); // This will display all tickets in the DataGridView
        }





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

   
    }
}