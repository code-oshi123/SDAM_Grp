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
            organizervieweventlinkLabel = new LinkLabel();
            organizerdeleteevntlinkLabel = new LinkLabel();
            organizereventlinkLabel = new LinkLabel();
            SuspendLayout();
            // 
            // organizeraddeventlinkLabel
            // 
            organizeraddeventlinkLabel.AutoSize = true;
            organizeraddeventlinkLabel.Location = new Point(337, 102);
            organizeraddeventlinkLabel.Name = "organizeraddeventlinkLabel";
            organizeraddeventlinkLabel.Size = new Size(129, 20);
            organizeraddeventlinkLabel.TabIndex = 0;
            organizeraddeventlinkLabel.TabStop = true;
            organizeraddeventlinkLabel.Text = "1.ADD/EDIT Event";
            organizeraddeventlinkLabel.LinkClicked += organizeraddeventlinkLabel_LinkClicked;
            // 
            // organizervieweventlinkLabel
            // 
            organizervieweventlinkLabel.AutoSize = true;
            organizervieweventlinkLabel.Location = new Point(337, 159);
            organizervieweventlinkLabel.Name = "organizervieweventlinkLabel";
            organizervieweventlinkLabel.Size = new Size(92, 20);
            organizervieweventlinkLabel.TabIndex = 1;
            organizervieweventlinkLabel.TabStop = true;
            organizervieweventlinkLabel.Text = "2.View Event";
            organizervieweventlinkLabel.LinkClicked += organizervieweventlinkLabel_LinkClicked;
            // 
            // organizerdeleteevntlinkLabel
            // 
            organizerdeleteevntlinkLabel.AutoSize = true;
            organizerdeleteevntlinkLabel.Location = new Point(337, 223);
            organizerdeleteevntlinkLabel.Name = "organizerdeleteevntlinkLabel";
            organizerdeleteevntlinkLabel.Size = new Size(104, 20);
            organizerdeleteevntlinkLabel.TabIndex = 2;
            organizerdeleteevntlinkLabel.TabStop = true;
            organizerdeleteevntlinkLabel.Text = "3.Delete Event";
            organizerdeleteevntlinkLabel.LinkClicked += organizerdeleteevntlinkLabel_LinkClicked;
            // 
            // organizereventlinkLabel
            // 
            organizereventlinkLabel.AutoSize = true;
            organizereventlinkLabel.Location = new Point(337, 279);
            organizereventlinkLabel.Name = "organizereventlinkLabel";
            organizereventlinkLabel.Size = new Size(92, 20);
            organizereventlinkLabel.TabIndex = 3;
            organizereventlinkLabel.TabStop = true;
            organizereventlinkLabel.Text = "4.View Event";
            organizereventlinkLabel.LinkClicked += organizereventlinkLabel_LinkClicked;
            // 
            // OrganizerMenuEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(organizereventlinkLabel);
            Controls.Add(organizerdeleteevntlinkLabel);
            Controls.Add(organizervieweventlinkLabel);
            Controls.Add(organizeraddeventlinkLabel);
            Name = "OrganizerMenuEventForm";
            Text = "OrganizerMenuEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private LinkLabel organizeraddeventlinkLabel;
        private LinkLabel organizervieweventlinkLabel;
        private LinkLabel organizerdeleteevntlinkLabel;
        private LinkLabel organizereventlinkLabel;
    }
}