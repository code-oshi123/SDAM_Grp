namespace WinFormsApp3
{
    partial class Form4
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {

            lblTotal = new Label();
            lblPrice = new Label();
            cmbTicketType = new ComboBox();
            btnLoadTickets = new Button();
            txtQuantity = new TextBox();
            label13 = new Label();
            label1 = new Label();
            txtEventID = new TextBox();
            label4 = new Label();
            label3 = new Label();
            btnLoadTickets.Click += new System.EventHandler(this.btnLoadTickets_Click);
            SuspendLayout();
            // 
            // lblTotal
            // 
            lblTotal.AutoEllipsis = true;
            lblTotal.AutoSize = true;
            lblTotal.Location = new Point(334, 379);
            lblTotal.MaximumSize = new Size(300, 100);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(138, 15);
            lblTotal.TabIndex = 42;
            lblTotal.Text = "\"Total Ticket Price : Rs. 0\"";
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Location = new Point(334, 349);
            lblPrice.MaximumSize = new Size(300, 100);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(125, 15);
            lblPrice.TabIndex = 41;
            lblPrice.Text = "\"Price per ticket: Rs. 0\"";
            // 
            // cmbTicketType
            // 
            cmbTicketType.FormattingEnabled = true;
            cmbTicketType.Items.AddRange(new object[] { "VIP", "Genaral" });
            cmbTicketType.Location = new Point(330, 160);
            cmbTicketType.Name = "cmbTicketType";
            cmbTicketType.Size = new Size(245, 23);
            cmbTicketType.TabIndex = 40;
            // 
            // btnLoadTickets
            // 
            btnLoadTickets.Location = new Point(361, 278);
            btnLoadTickets.Name = "btnLoadTickets";
            btnLoadTickets.Size = new Size(125, 23);
            btnLoadTickets.TabIndex = 39;
            btnLoadTickets.Text = "Place Ticket";
            btnLoadTickets.UseVisualStyleBackColor = true;
            // 
            // txtQuantity
            // 
            txtQuantity.Location = new Point(330, 198);
            txtQuantity.Name = "txtQuantity";
            txtQuantity.Size = new Size(245, 23);
            txtQuantity.TabIndex = 38;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(226, 203);
            label13.Name = "label13";
            label13.Size = new Size(59, 15);
            label13.TabIndex = 37;
            label13.Text = "Quantity :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(334, 57);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 36;
            label1.Text = "--Ticket Management System--";
            // 
            // txtEventID
            // 
            txtEventID.Location = new Point(330, 118);
            txtEventID.Name = "txtEventID";
            txtEventID.Size = new Size(245, 23);
            txtEventID.TabIndex = 35;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(226, 163);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 34;
            label4.Text = "Ticket Type:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(225, 124);
            label3.Name = "label3";
            label3.Size = new Size(53, 15);
            label3.TabIndex = 33;
            label3.Text = "Event ID:";
            // 
            // Form4
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblTotal);
            Controls.Add(lblPrice);
            Controls.Add(cmbTicketType);
            Controls.Add(btnLoadTickets);
            Controls.Add(txtQuantity);
            Controls.Add(label13);
            Controls.Add(label1);
            Controls.Add(txtEventID);
            Controls.Add(label4);
            Controls.Add(label3);
            Name = "Form4";
            Text = "Form4";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTotal;
        private Label lblPrice;
        private ComboBox cmbTicketType;
        private Button btnLoadTickets;
        private TextBox txtQuantity;
        private Label label13;
        private Label label1;
        private TextBox txtEventID;
        private Label label4;
        private Label label3;
    }
}