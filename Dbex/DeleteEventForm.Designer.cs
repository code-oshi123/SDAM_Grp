namespace Dbex
{
    partial class DeleteEventForm
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
            label = new Label();
            label3 = new Label();
            deleteeventidtextBox = new TextBox();
            deleteeventnametextBox = new TextBox();
            button1 = new Button();
            button2 = new Button();
            label4 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(347, 36);
            label1.Name = "label1";
            label1.Size = new Size(126, 20);
            label1.TabIndex = 0;
            label1.Text = "Delete Your Event";
            // 
            // label
            // 
            label.AutoSize = true;
            label.Location = new Point(265, 121);
            label.Name = "label";
            label.Size = new Size(80, 20);
            label.TabIndex = 1;
            label.Text = "1. Event Id:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(265, 197);
            label3.Name = "label3";
            label3.Size = new Size(103, 20);
            label3.TabIndex = 2;
            label3.Text = "2.Event Name:";
            // 
            // deleteeventidtextBox
            // 
            deleteeventidtextBox.Location = new Point(414, 118);
            deleteeventidtextBox.Name = "deleteeventidtextBox";
            deleteeventidtextBox.Size = new Size(125, 27);
            deleteeventidtextBox.TabIndex = 3;
            deleteeventidtextBox.TextChanged += deleteeventnametextBox_TextChanged;
            // 
            // deleteeventnametextBox
            // 
            deleteeventnametextBox.Location = new Point(414, 190);
            deleteeventnametextBox.Name = "deleteeventnametextBox";
            deleteeventnametextBox.Size = new Size(125, 27);
            deleteeventnametextBox.TabIndex = 4;
            // 
            // button1
            // 
            button1.Location = new Point(247, 298);
            button1.Name = "button1";
            button1.Size = new Size(146, 29);
            button1.TabIndex = 5;
            button1.Text = "Delete Event";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(546, 298);
            button2.Name = "button2";
            button2.Size = new Size(129, 29);
            button2.TabIndex = 6;
            button2.Text = "Back to menu";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(247, 397);
            label4.Name = "label4";
            label4.Size = new Size(344, 20);
            label4.TabIndex = 7;
            label4.Text = "*When you delete Event ,Tickets will also be delete";
            // 
            // DeleteEventForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(label4);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(deleteeventnametextBox);
            Controls.Add(deleteeventidtextBox);
            Controls.Add(label3);
            Controls.Add(label);
            Controls.Add(label1);
            Name = "DeleteEventForm";
            Text = "DeleteEventForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label;
        private Label label3;
        private TextBox deleteeventidtextBox;
        private TextBox deleteeventnametextBox;
        private Button button1;
        private Button button2;
        private Label label4;
    }
}