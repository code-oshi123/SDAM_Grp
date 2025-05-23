namespace Dbex
{
    partial class MenuForm
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
            label1 = new Label();
            linkLabel1 = new LinkLabel();
            linkLabel2 = new LinkLabel();
            linkLabel3 = new LinkLabel();
            Viewfeedbacklabel = new LinkLabel();
            admindashboardlinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(303, 73);
            label1.Name = "label1";
            label1.Size = new Size(135, 20);
            label1.TabIndex = 0;
            label1.Text = "Event system Menu";
            // 
            // linkLabel1
            // 
            linkLabel1.AutoSize = true;
            linkLabel1.Location = new Point(304, 131);
            linkLabel1.Name = "linkLabel1";
            linkLabel1.Size = new Size(134, 20);
            linkLabel1.TabIndex = 1;
            linkLabel1.TabStop = true;
            linkLabel1.Text = "1.Add / Edit Events";
            linkLabel1.LinkClicked += linkLabel1_LinkClicked;
            // 
            // linkLabel2
            // 
            linkLabel2.AutoSize = true;
            linkLabel2.Location = new Point(303, 181);
            linkLabel2.Name = "linkLabel2";
            linkLabel2.Size = new Size(98, 20);
            linkLabel2.TabIndex = 2;
            linkLabel2.TabStop = true;
            linkLabel2.Text = "2.View Events";
            linkLabel2.LinkClicked += linkLabel2_LinkClicked;
            // 
            // linkLabel3
            // 
            linkLabel3.AutoSize = true;
            linkLabel3.Location = new Point(303, 232);
            linkLabel3.Name = "linkLabel3";
            linkLabel3.Size = new Size(104, 20);
            linkLabel3.TabIndex = 3;
            linkLabel3.TabStop = true;
            linkLabel3.Text = "3.Delete Event";
            linkLabel3.LinkClicked += linkLabel3_LinkClicked;
            // 
            // Viewfeedbacklabel
            // 
            Viewfeedbacklabel.AutoSize = true;
            Viewfeedbacklabel.Location = new Point(304, 280);
            Viewfeedbacklabel.Name = "Viewfeedbacklabel";
            Viewfeedbacklabel.Size = new Size(119, 20);
            Viewfeedbacklabel.TabIndex = 4;
            Viewfeedbacklabel.TabStop = true;
            Viewfeedbacklabel.Text = "4.View FeedBack";
            Viewfeedbacklabel.LinkClicked += Viewfeedbacklabel_LinkClicked;
            // 
            // admindashboardlinkLabel
            // 
            admindashboardlinkLabel.AutoSize = true;
            admindashboardlinkLabel.Location = new Point(304, 334);
            admindashboardlinkLabel.Name = "admindashboardlinkLabel";
            admindashboardlinkLabel.Size = new Size(141, 20);
            admindashboardlinkLabel.TabIndex = 5;
            admindashboardlinkLabel.TabStop = true;
            admindashboardlinkLabel.Text = "5.Admin Dashboard";
            admindashboardlinkLabel.LinkClicked += admindashboardlinkLabel_LinkClicked;
            // 
            // MenuForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(admindashboardlinkLabel);
            Controls.Add(Viewfeedbacklabel);
            Controls.Add(linkLabel3);
            Controls.Add(linkLabel2);
            Controls.Add(linkLabel1);
            Controls.Add(label1);
            Name = "MenuForm";
            Text = "MenuForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private LinkLabel linkLabel1;
        private LinkLabel linkLabel2;
        private LinkLabel linkLabel3;
        private LinkLabel Viewfeedbacklabel;
        private LinkLabel admindashboardlinkLabel;
    }
}