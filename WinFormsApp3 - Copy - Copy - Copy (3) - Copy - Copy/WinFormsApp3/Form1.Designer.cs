namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label13 = new Label();
            txtEventID = new TextBox();
            txtAvailability = new TextBox();
            txtPrice = new TextBox();
            btnAddTicket = new Button();
            btnUpdatePrice = new Button();
            btnDeleteTicket = new Button();
            txtUpdateTicketID = new TextBox();
            label2 = new Label();
            txtNewPrice = new TextBox();
            label6 = new Label();
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            btnViewTickets = new Button();
            txtDeleteTicketID = new TextBox();
            label7 = new Label();
            cmbType = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(343, 47);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 0;
            label1.Text = "--Ticket Management System--";
            label1.Click += label1_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(140, 93);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 2;
            label3.Text = "Event ID:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(135, 132);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 3;
            label4.Text = "Ticket Type:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(140, 174);
            label5.Name = "label5";
            label5.Size = new Size(36, 15);
            label5.TabIndex = 4;
            label5.Text = "Price:";
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(135, 214);
            label13.Name = "label13";
            label13.Size = new Size(68, 15);
            label13.TabIndex = 12;
            label13.Text = "Availability:";
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(239, 87);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(121, 23);
            txtEventID.TabIndex = 13;
            // 
            // txtAvailability
            // 
            txtAvailability.Location = new Point(239, 209);
            txtAvailability.Name = "txtAvailability";
            txtAvailability.Size = new Size(121, 23);
            txtAvailability.TabIndex = 14;
            // 
            // txtPrice
            // 
            txtPrice.Location = new Point(239, 170);
            txtPrice.Name = "txtPrice";
            txtPrice.Size = new Size(121, 23);
            txtPrice.TabIndex = 15;
            // 
            // btnAddTicket
            // 
            btnAddTicket.Location = new Point(192, 242);
            btnAddTicket.Name = "btnAddTicket";
            btnAddTicket.Size = new Size(125, 23);
            btnAddTicket.TabIndex = 17;
            btnAddTicket.Text = "Add Ticket";
            btnAddTicket.UseVisualStyleBackColor = true;
            btnAddTicket.Click += btnAddTicket_Click;
            // 
            // btnUpdatePrice
            // 
            btnUpdatePrice.Location = new Point(520, 148);
            btnUpdatePrice.Name = "btnUpdatePrice";
            btnUpdatePrice.Size = new Size(125, 23);
            btnUpdatePrice.TabIndex = 18;
            btnUpdatePrice.Text = "Update Price";
            btnUpdatePrice.UseVisualStyleBackColor = true;
            // 
            // btnDeleteTicket
            // 
            btnDeleteTicket.Location = new Point(520, 242);
            btnDeleteTicket.Name = "btnDeleteTicket";
            btnDeleteTicket.Size = new Size(125, 23);
            btnDeleteTicket.TabIndex = 19;
            btnDeleteTicket.Text = "Delete Ticket";
            btnDeleteTicket.UseVisualStyleBackColor = true;
            // 
            // txtUpdateTicketID
            // 
            txtUpdateTicketID.Location = new Point(524, 85);
            txtUpdateTicketID.Name = "txtUpdateTicketID";
            txtUpdateTicketID.Size = new Size(121, 23);
            txtUpdateTicketID.TabIndex = 22;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(425, 89);
            label2.Name = "label2";
            label2.Size = new Size(55, 15);
            label2.TabIndex = 21;
            label2.Text = "Ticket ID:";
            // 
            // txtNewPrice
            // 
            txtNewPrice.Location = new Point(524, 119);
            txtNewPrice.Name = "txtNewPrice";
            txtNewPrice.Size = new Size(121, 23);
            txtNewPrice.TabIndex = 24;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(425, 123);
            label6.Name = "label6";
            label6.Size = new Size(63, 15);
            label6.TabIndex = 23;
            label6.Text = "New Price:";
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewTickets.Location = new Point(173, 297);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.RowTemplate.Height = 25;
            dataGridViewTickets.Size = new Size(536, 193);
            dataGridViewTickets.TabIndex = 25;
            dataGridViewTickets.CellContentClick += dataGridViewTickets_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "ID";
            Column1.Name = "Column1";
            // 
            // Column2
            // 
            Column2.HeaderText = "EventID";
            Column2.Name = "Column2";
            // 
            // Column3
            // 
            Column3.HeaderText = "Type";
            Column3.Name = "Column3";
            // 
            // Column4
            // 
            Column4.HeaderText = "Price";
            Column4.Name = "Column4";
            // 
            // Column5
            // 
            Column5.HeaderText = "Availability";
            Column5.Name = "Column5";
            // 
            // btnViewTickets
            // 
            btnViewTickets.Location = new Point(383, 514);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(119, 23);
            btnViewTickets.TabIndex = 26;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = true;
            // 
            // txtDeleteTicketID
            // 
            txtDeleteTicketID.Location = new Point(520, 213);
            txtDeleteTicketID.Name = "txtDeleteTicketID";
            txtDeleteTicketID.Size = new Size(121, 23);
            txtDeleteTicketID.TabIndex = 28;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(421, 217);
            label7.Name = "label7";
            label7.Size = new Size(55, 15);
            label7.TabIndex = 27;
            label7.Text = "Ticket ID:";
            // 
            // cmbType
            // 
            cmbType.FormattingEnabled = true;
            cmbType.Items.AddRange(new object[] { "VIP", "Genaral" });
            cmbType.Location = new Point(239, 129);
            cmbType.Name = "cmbType";
            cmbType.Size = new Size(121, 23);
            cmbType.TabIndex = 29;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 550);
            Controls.Add(cmbType);
            Controls.Add(txtDeleteTicketID);
            Controls.Add(label7);
            Controls.Add(btnViewTickets);
            Controls.Add(dataGridViewTickets);
            Controls.Add(txtNewPrice);
            Controls.Add(label6);
            Controls.Add(txtUpdateTicketID);
            Controls.Add(label2);
            Controls.Add(btnDeleteTicket);
            Controls.Add(btnUpdatePrice);
            Controls.Add(btnAddTicket);
            Controls.Add(txtPrice);
            Controls.Add(txtAvailability);
            Controls.Add(txtEventID);
            Controls.Add(label13);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label13;
        private TextBox txtEventID;
        private TextBox txtAvailability;
        private TextBox txtPrice;
        private Button btnAddTicket;
        private Button btnUpdatePrice;
        private Button btnDeleteTicket;
        private TextBox txtUpdateTicketID;
        private Label label2;
        private TextBox txtNewPrice;
        private Label label6;
        private DataGridView dataGridViewTickets;
        private Button btnViewTickets;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private TextBox txtDeleteTicketID;
        private Label label7;
        private ComboBox cmbType;
    }
}