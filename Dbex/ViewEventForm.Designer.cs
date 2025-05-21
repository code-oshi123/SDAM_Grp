namespace Dbex
{
    partial class ViewEventForm
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
            ViewEventlistBox = new ListBox();
            Vieeventbutton = new Button();
            label1 = new Label();
            button1 = new Button();
            SuspendLayout();
            // 
            // ViewEventlistBox
            // 
            ViewEventlistBox.FormattingEnabled = true;
            ViewEventlistBox.Location = new Point(152, 108);
            ViewEventlistBox.Name = "ViewEventlistBox";
            ViewEventlistBox.Size = new Size(492, 224);
            ViewEventlistBox.TabIndex = 0;
            // 
            // Vieeventbutton
            // 
            Vieeventbutton.Location = new Point(118, 362);
            Vieeventbutton.Name = "Vieeventbutton";
            Vieeventbutton.Size = new Size(94, 29);
            Vieeventbutton.TabIndex = 1;
            Vieeventbutton.Text = "View Event";
            Vieeventbutton.UseVisualStyleBackColor = true;
            Vieeventbutton.Click += Vieeventbutton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(277, 48);
            label1.Name = "label1";
            label1.Size = new Size(167, 20);
            label1.TabIndex = 2;
            label1.Text = "Press the button to view";
            // 
            // button1
            // 
            button1.Location = new Point(524, 362);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 3;
            button1.Text = "Back to Menu";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // ViewEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(label1);
            Controls.Add(Vieeventbutton);
            Controls.Add(ViewEventlistBox);
            Name = "ViewEventForm";
            Text = "ViewEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox ViewEventlistBox;
        private Button Vieeventbutton;
        private Label label1;
        private Button button1;
    }
}