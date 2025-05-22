namespace Adminloginform
{
    partial class Homepage
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
            username_tb = new TextBox();
            password_tb = new TextBox();
            login_btn = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14F);
            label1.Location = new Point(75, 109);
            label1.Name = "label1";
            label1.Size = new Size(97, 25);
            label1.TabIndex = 0;
            label1.Text = "Username";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 14F);
            label2.Location = new Point(75, 200);
            label2.Name = "label2";
            label2.Size = new Size(91, 25);
            label2.TabIndex = 1;
            label2.Text = "Password";
            // 
            // username_tb
            // 
            username_tb.Location = new Point(196, 115);
            username_tb.Name = "username_tb";
            username_tb.Size = new Size(303, 23);
            username_tb.TabIndex = 2;
            // 
            // password_tb
            // 
            password_tb.Location = new Point(196, 200);
            password_tb.Name = "password_tb";
            password_tb.PasswordChar = '*';
            password_tb.Size = new Size(303, 23);
            password_tb.TabIndex = 3;
            // 
            // login_btn
            // 
            login_btn.Location = new Point(418, 287);
            login_btn.Name = "login_btn";
            login_btn.Size = new Size(81, 34);
            login_btn.TabIndex = 4;
            login_btn.Text = "Login";
            login_btn.UseVisualStyleBackColor = true;
            login_btn.Click += login_btn_Click;
            // 
            // Homepage
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(557, 379);
            Controls.Add(login_btn);
            Controls.Add(password_tb);
            Controls.Add(username_tb);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Homepage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Homepage";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox username_tb;
        private TextBox password_tb;
        private Button login_btn;
    }
}