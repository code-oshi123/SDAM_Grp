namespace Dbex
{
    partial class ViewReviewForm
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
            reviewidtextBox = new TextBox();
            revieweventnametextBox = new TextBox();
            reviewtextBox = new TextBox();
            Addreviewbtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(198, 93);
            label1.Name = "label1";
            label1.Size = new Size(73, 20);
            label1.TabIndex = 0;
            label1.Text = "1.Event Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(198, 184);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 1;
            label2.Text = "2.Event Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 244);
            label3.Name = "label3";
            label3.Size = new Size(67, 20);
            label3.TabIndex = 2;
            label3.Text = "3.Review";
            // 
            // reviewidtextBox
            // 
            reviewidtextBox.Location = new Point(330, 98);
            reviewidtextBox.Name = "reviewidtextBox";
            reviewidtextBox.Size = new Size(179, 27);
            reviewidtextBox.TabIndex = 3;
            // 
            // revieweventnametextBox
            // 
            revieweventnametextBox.Location = new Point(330, 177);
            revieweventnametextBox.Name = "revieweventnametextBox";
            revieweventnametextBox.Size = new Size(125, 27);
            revieweventnametextBox.TabIndex = 4;
            // 
            // reviewtextBox
            // 
            reviewtextBox.Location = new Point(330, 244);
            reviewtextBox.Name = "reviewtextBox";
            reviewtextBox.Size = new Size(416, 27);
            reviewtextBox.TabIndex = 5;
            // 
            // Addreviewbtn
            // 
            Addreviewbtn.Location = new Point(285, 342);
            Addreviewbtn.Name = "Addreviewbtn";
            Addreviewbtn.Size = new Size(145, 29);
            Addreviewbtn.TabIndex = 6;
            Addreviewbtn.Text = "Add Review";
            Addreviewbtn.UseVisualStyleBackColor = true;
            Addreviewbtn.Click += Addreviewbtn_Click;
            // 
            // ViewReviewForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Addreviewbtn);
            Controls.Add(reviewtextBox);
            Controls.Add(revieweventnametextBox);
            Controls.Add(reviewidtextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "ViewReviewForm";
            Text = "ViewReviewForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox reviewidtextBox;
        private TextBox revieweventnametextBox;
        private TextBox reviewtextBox;
        private Button Addreviewbtn;
    }
}