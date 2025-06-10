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
using WinFormsApp3.Models;


namespace WinFormsApp3
{
    public partial class Form2 : Form
    {
        private TicketController ticketController = new TicketController();

        public Form2()
        {
            InitializeComponent();
            btnViewTickets.Click += btnViewTickets_Click;

        }
        private void Form2_Load(object sender, EventArgs e)
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
            var tickets = ticketController.GetAllTickets();

            foreach (var ticket in tickets)
            {
                dataGridViewTickets.Rows.Add(
                    ticket.TicketID,
                    ticket.EventID,
                    ticket.Type,
                    ticket.Price,
                    ticket.Availability
                );
            }
        }


        private void btnViewTickets_Click(object sender, EventArgs e)
        {
            RefreshTicketList();
        }


        private void dataGridViewTickets_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
