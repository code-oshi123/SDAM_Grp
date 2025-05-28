namespace Dbex
{
    partial class AdminevviewForm
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
            adminevviewlistBox = new ListBox();
            vieweventadminbackbutton = new Button();
            vieweventsadminbutton = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(352, 46);
            label1.Name = "label1";
            label1.Size = new Size(87, 20);
            label1.TabIndex = 0;
            label1.Text = "View Events";
            // 
            // adminevviewlistBox
            // 
            adminevviewlistBox.FormattingEnabled = true;
            adminevviewlistBox.Location = new Point(161, 103);
            adminevviewlistBox.Name = "adminevviewlistBox";
            adminevviewlistBox.Size = new Size(537, 244);
            adminevviewlistBox.TabIndex = 1;
            // 
            // vieweventadminbackbutton
            // 
            vieweventadminbackbutton.Location = new Point(534, 380);
            vieweventadminbackbutton.Name = "vieweventadminbackbutton";
            vieweventadminbackbutton.Size = new Size(216, 29);
            vieweventadminbackbutton.TabIndex = 2;
            vieweventadminbackbutton.Text = "Back to Add Event Form";
            vieweventadminbackbutton.UseVisualStyleBackColor = true;
            vieweventadminbackbutton.Click += vieweventadminbackbutton_Click;
            // 
            // vieweventsadminbutton
            // 
            vieweventsadminbutton.Location = new Point(177, 380);
            vieweventsadminbutton.Name = "vieweventsadminbutton";
            vieweventsadminbutton.Size = new Size(140, 29);
            vieweventsadminbutton.TabIndex = 3;
            vieweventsadminbutton.Text = "View Events";
            vieweventsadminbutton.UseVisualStyleBackColor = true;
            vieweventsadminbutton.Click += vieweventsadminbutton_Click;
            // 
            // AdminevviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(vieweventsadminbutton);
            Controls.Add(vieweventadminbackbutton);
            Controls.Add(adminevviewlistBox);
            Controls.Add(label1);
            Name = "AdminevviewForm";
            Text = "AdminevviewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox adminevviewlistBox;
        private Button vieweventadminbackbutton;
        private Button vieweventsadminbutton;
    }
}