namespace Dbex
{
    partial class AdditemForm
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
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            eidtextBox = new TextBox();
            enametextBox = new TextBox();
            eloctextBox = new TextBox();
            edestextBox = new TextBox();
            addevntbutton = new Button();
            label6 = new Label();
            datetextBox = new TextBox();
            edateTimePicker = new DateTimePicker();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(222, 85);
            label1.Name = "label1";
            label1.Size = new Size(62, 20);
            label1.TabIndex = 0;
            label1.Text = "Event Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(222, 128);
            label2.Name = "label2";
            label2.Size = new Size(89, 20);
            label2.TabIndex = 1;
            label2.Text = "Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(222, 217);
            label3.Name = "label3";
            label3.Size = new Size(106, 20);
            label3.TabIndex = 2;
            label3.Text = "Event Location";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(222, 174);
            label4.Name = "label4";
            label4.Size = new Size(81, 20);
            label4.TabIndex = 3;
            label4.Text = "Event Date";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(222, 264);
            label5.Name = "label5";
            label5.Size = new Size(125, 20);
            label5.TabIndex = 4;
            label5.Text = "Event Description";
            // 
            // eidtextBox
            // 
            eidtextBox.Location = new Point(399, 82);
            eidtextBox.Name = "eidtextBox";
            eidtextBox.Size = new Size(125, 27);
            eidtextBox.TabIndex = 5;
            // 
            // enametextBox
            // 
            enametextBox.Location = new Point(399, 128);
            enametextBox.Name = "enametextBox";
            enametextBox.Size = new Size(125, 27);
            enametextBox.TabIndex = 6;
            // 
            // eloctextBox
            // 
            eloctextBox.Location = new Point(399, 217);
            eloctextBox.Name = "eloctextBox";
            eloctextBox.Size = new Size(125, 27);
            eloctextBox.TabIndex = 7;
            // 
            // edestextBox
            // 
            edestextBox.Location = new Point(399, 264);
            edestextBox.Name = "edestextBox";
            edestextBox.Size = new Size(125, 27);
            edestextBox.TabIndex = 8;
            // 
            // addevntbutton
            // 
            addevntbutton.Location = new Point(337, 354);
            addevntbutton.Name = "addevntbutton";
            addevntbutton.Size = new Size(94, 29);
            addevntbutton.TabIndex = 10;
            addevntbutton.Text = "Add Event";
            addevntbutton.UseVisualStyleBackColor = true;
            addevntbutton.Click += addevntbutton_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(337, 29);
            label6.Name = "label6";
            label6.Size = new Size(125, 20);
            label6.TabIndex = 11;
            label6.Text = "Add or Edit Event";
            // 
            // datetextBox
            // 
            datetextBox.Location = new Point(648, 411);
            datetextBox.Name = "datetextBox";
            datetextBox.Size = new Size(125, 27);
            datetextBox.TabIndex = 12;
            // 
            // edateTimePicker
            // 
            edateTimePicker.Location = new Point(399, 174);
            edateTimePicker.Name = "edateTimePicker";
            edateTimePicker.Size = new Size(250, 27);
            edateTimePicker.TabIndex = 13;
            // 
            // AdditemForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(edateTimePicker);
            Controls.Add(datetextBox);
            Controls.Add(label6);
            Controls.Add(addevntbutton);
            Controls.Add(edestextBox);
            Controls.Add(eloctextBox);
            Controls.Add(enametextBox);
            Controls.Add(eidtextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AdditemForm";
            Text = "AdditemForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox eidtextBox;
        private TextBox enametextBox;
        private TextBox eloctextBox;
        private TextBox edestextBox;
        private Button addevntbutton;
        private Label label6;
        private TextBox datetextBox;
        private DateTimePicker edateTimePicker;
    }
}