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
        //private void btnOpenBooking_Click(object sender, EventArgs e)
        //{
        //    if (int.TryParse(txtEventID.Text, out int eventID))
        //    {
        //        Form4 bookingForm = new form4(eventID);
        //        bookingForm.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a valid Event ID before opening the booking form.");
        //    }
        //}



        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridViewTickets.ColumnCount = 5;
            dataGridViewTickets.Columns[0].Name = "Ticket ID";
            dataGridViewTickets.Columns[1].Name = "Event ID";
            dataGridViewTickets.Columns[2].Name = "Type";
            dataGridViewTickets.Columns[3].Name = "Price";
            dataGridViewTickets.Columns[4].Name = "Availability";

           
            cmbType.SelectedIndex = 0;
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
            // Validate empty fields
            if (string.IsNullOrWhiteSpace(txtEventID.Text) ||
                cmbType.SelectedItem == null ||
                string.IsNullOrWhiteSpace(txtPrice.Text) ||
                string.IsNullOrWhiteSpace(txtAvailability.Text))
            {
                MessageBox.Show("Please fill in all required fields.", "Missing Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                int eventId = int.Parse(txtEventID.Text);
                string type = cmbType.SelectedItem.ToString();
                decimal price = decimal.Parse(txtPrice.Text);
                int availability = int.Parse(txtAvailability.Text);

                ticketController.AddTicket(eventId, type, price, availability);
                RefreshTicketList(); // reload updated data
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            try
            {
                int eventId = int.Parse(txtEventID.Text);
                string type = cmbType.SelectedItem.ToString();
                decimal price = decimal.Parse(txtPrice.Text);
                int availability = int.Parse(txtAvailability.Text);

                // Check for existing ticket
                if (ticketController.TicketExists(eventId, type))
                {
                    MessageBox.Show("A ticket with this Event ID and Type already exists.", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                ticketController.AddTicket(eventId, type, price, availability);
                RefreshTicketList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void btnBook_Click(object sender, EventArgs e)
        {

            if (!int.TryParse(txtEventID.Text, out int eventId))
            {
                MessageBox.Show("Invalid Event ID.");
                return;
            }

            string ticketType = cmbType.SelectedItem?.ToString();

            if (!ticketController.IsValidTicketType(eventId, ticketType))
            {
                MessageBox.Show("Invalid ticket type for this event.", "Invalid Ticket Type", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Proceed with booking logic here
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

        //private void btnOpenForm3_Click(object sender, EventArgs e)
        //{
        //    if (int.TryParse(txtEventID.Text, out int eventID))
        //    {
        //        Form3 form3 = new Form3(eventID);
        //        form3.Show();
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please enter a valid Event ID.");
        //    }
        //}





        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {


        }

        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}