namespace Dbex
{
    partial class OrganizerMenuEventForm
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
            organizeraddeventlinkLabel = new LinkLabel();
            organizerdeleteevntlinkLabel = new LinkLabel();
            label1 = new Label();
            SuspendLayout();
            // 
            // organizeraddeventlinkLabel
            // 
            organizeraddeventlinkLabel.AutoSize = true;
            organizeraddeventlinkLabel.Location = new Point(337, 183);
            organizeraddeventlinkLabel.Name = "organizeraddeventlinkLabel";
            organizeraddeventlinkLabel.Size = new Size(129, 20);
            organizeraddeventlinkLabel.TabIndex = 0;
            organizeraddeventlinkLabel.TabStop = true;
            organizeraddeventlinkLabel.Text = "1.ADD/EDIT Event";
            organizeraddeventlinkLabel.LinkClicked += organizeraddeventlinkLabel_LinkClicked;
            // 
            // organizerdeleteevntlinkLabel
            // 
            organizerdeleteevntlinkLabel.AutoSize = true;
            organizerdeleteevntlinkLabel.Location = new Point(337, 232);
            organizerdeleteevntlinkLabel.Name = "organizerdeleteevntlinkLabel";
            organizerdeleteevntlinkLabel.Size = new Size(104, 20);
            organizerdeleteevntlinkLabel.TabIndex = 2;
            organizerdeleteevntlinkLabel.TabStop = true;
            organizerdeleteevntlinkLabel.Text = "2.Delete Event";
            organizerdeleteevntlinkLabel.LinkClicked += organizerdeleteevntlinkLabel_LinkClicked;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(337, 72);
            label1.Name = "label1";
            label1.Size = new Size(115, 20);
            label1.TabIndex = 4;
            label1.Text = "Organizer Menu";
            // 
            // OrganizerMenuEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label1);
            Controls.Add(organizerdeleteevntlinkLabel);
            Controls.Add(organizeraddeventlinkLabel);
            Name = "OrganizerMenuEventForm";
            Text = "OrganizerMenuEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel organizeraddeventlinkLabel;
        private LinkLabel organizerdeleteevntlinkLabel;
        private Label label1;
    }
}