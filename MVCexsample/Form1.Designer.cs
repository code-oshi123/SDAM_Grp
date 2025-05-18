namespace MVCexsample
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
            label2 = new Label();
            txtstudentname = new TextBox();
            txtstudentage = new TextBox();
            Add = new Button();
            StudentlistBox = new ListBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(109, 90);
            label1.Name = "label1";
            label1.Size = new Size(104, 20);
            label1.TabIndex = 0;
            label1.Text = "Student Name";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(109, 145);
            label2.Name = "label2";
            label2.Size = new Size(91, 20);
            label2.TabIndex = 1;
            label2.Text = "Student Age";
            // 
            // txtstudentname
            // 
            txtstudentname.Location = new Point(274, 96);
            txtstudentname.Name = "txtstudentname";
            txtstudentname.Size = new Size(125, 27);
            txtstudentname.TabIndex = 2;
            txtstudentname.Text = "u";
            txtstudentname.TextChanged += txtstudentname_TextChanged;
            // 
            // txtstudentage
            // 
            txtstudentage.Location = new Point(274, 145);
            txtstudentage.Name = "txtstudentage";
            txtstudentage.Size = new Size(125, 27);
            txtstudentage.TabIndex = 3;
            txtstudentage.TextChanged += txtstudentage_TextChanged;
            // 
            // Add
            // 
            Add.Location = new Point(61, 234);
            Add.Name = "Add";
            Add.Size = new Size(152, 29);
            Add.TabIndex = 4;
            Add.Text = "Add student";
            Add.UseVisualStyleBackColor = true;
            Add.Click += Add_Click;
            // 
            // StudentlistBox
            // 
            StudentlistBox.FormattingEnabled = true;
            StudentlistBox.Location = new Point(546, 90);
            StudentlistBox.Name = "StudentlistBox";
            StudentlistBox.Size = new Size(250, 244);
            StudentlistBox.TabIndex = 5;
            StudentlistBox.SelectedIndexChanged += listBox1_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StudentlistBox);
            Controls.Add(Add);
            Controls.Add(txtstudentage);
            Controls.Add(txtstudentname);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtstudentname;
        private TextBox txtstudentage;
        private Button Add;
        private ListBox StudentlistBox;
    }
}
