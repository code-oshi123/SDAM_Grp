namespace WinFormsApp3
{
    partial class Form2
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
            dataGridViewTickets = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            Column5 = new DataGridViewTextBoxColumn();
            label1 = new Label();
            btnViewTickets = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewTickets
            // 
            dataGridViewTickets.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewTickets.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4, Column5 });
            dataGridViewTickets.Location = new Point(141, 122);
            dataGridViewTickets.Name = "dataGridViewTickets";
            dataGridViewTickets.RowTemplate.Height = 25;
            dataGridViewTickets.Size = new Size(536, 193);
            dataGridViewTickets.TabIndex = 26;
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
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(325, 62);
            label1.Name = "label1";
            label1.Size = new Size(173, 15);
            label1.TabIndex = 27;
            label1.Text = "--Ticket Management System--";
            // 
            // btnViewTickets
            // 
            btnViewTickets.Location = new Point(346, 344);
            btnViewTickets.Name = "btnViewTickets";
            btnViewTickets.Size = new Size(119, 23);
            btnViewTickets.TabIndex = 28;
            btnViewTickets.Text = "View Tickets";
            btnViewTickets.UseVisualStyleBackColor = true;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnViewTickets);
            Controls.Add(label1);
            Controls.Add(dataGridViewTickets);
            Name = "Form2";
            Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)dataGridViewTickets).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewTickets;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
        private Label label1;
        private Button btnViewTickets;
    }
}