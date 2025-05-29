namespace Dbex
{
    partial class ViewFeedbackForm
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
            Feedbackviewlistbox = new ListBox();
            viewfeeedbackbtn = new Button();
            feedbackbacktomenubtn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(260, 41);
            label1.Name = "label1";
            label1.Size = new Size(251, 20);
            label1.TabIndex = 0;
            label1.Text = "Press View Button to view Feedbacks";
            // 
            // Feedbackviewlistbox
            // 
            Feedbackviewlistbox.FormattingEnabled = true;
            Feedbackviewlistbox.Location = new Point(175, 93);
            Feedbackviewlistbox.Name = "Feedbackviewlistbox";
            Feedbackviewlistbox.Size = new Size(424, 264);
            Feedbackviewlistbox.TabIndex = 1;
            // 
            // viewfeeedbackbtn
            // 
            viewfeeedbackbtn.Location = new Point(88, 389);
            viewfeeedbackbtn.Name = "viewfeeedbackbtn";
            viewfeeedbackbtn.Size = new Size(195, 29);
            viewfeeedbackbtn.TabIndex = 2;
            viewfeeedbackbtn.Text = "View Feedback";
            viewfeeedbackbtn.UseVisualStyleBackColor = true;
            viewfeeedbackbtn.Click += viewfeeedbackbtn_Click;
            // 
            // feedbackbacktomenubtn
            // 
            feedbackbacktomenubtn.Location = new Point(543, 389);
            feedbackbacktomenubtn.Name = "feedbackbacktomenubtn";
            feedbackbacktomenubtn.Size = new Size(123, 29);
            feedbackbacktomenubtn.TabIndex = 3;
            feedbackbacktomenubtn.Text = "Back to Menu";
            feedbackbacktomenubtn.UseVisualStyleBackColor = true;
            feedbackbacktomenubtn.Click += feedbackbacktomenubtn_Click;
            // 
            // ViewFeedbackForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(feedbackbacktomenubtn);
            Controls.Add(viewfeeedbackbtn);
            Controls.Add(Feedbackviewlistbox);
            Controls.Add(label1);
            Name = "ViewFeedbackForm";
            Text = "ViewFeedbackForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ListBox Feedbackviewlistbox;
        private Button viewfeeedbackbtn;
        private Button feedbackbacktomenubtn;
    }
}