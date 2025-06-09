namespace Dbex
{
    partial class AddLocationForm2
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
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            locnameaddtextBox = new TextBox();
            locadressaddtextBox = new TextBox();
            locowneraddtextBox = new TextBox();
            addlocadbutton1 = new Button();
            addlocbackbutton2 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 123);
            label1.Name = "label1";
            label1.Size = new Size(60, 20);
            label1.TabIndex = 0;
            label1.Text = "1.Name";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(177, 182);
            label3.Name = "label3";
            label3.Size = new Size(64, 20);
            label3.TabIndex = 2;
            label3.Text = "2.Adress";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(181, 234);
            label4.Name = "label4";
            label4.Size = new Size(107, 20);
            label4.TabIndex = 3;
            label4.Text = "2.Owner Name";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(329, 44);
            label5.Name = "label5";
            label5.Size = new Size(98, 20);
            label5.TabIndex = 4;
            label5.Text = "Add Location";
            // 
            // locnameaddtextBox
            // 
            locnameaddtextBox.Location = new Point(392, 120);
            locnameaddtextBox.Name = "locnameaddtextBox";
            locnameaddtextBox.Size = new Size(125, 27);
            locnameaddtextBox.TabIndex = 5;
            // 
            // locadressaddtextBox
            // 
            locadressaddtextBox.Location = new Point(392, 175);
            locadressaddtextBox.Name = "locadressaddtextBox";
            locadressaddtextBox.Size = new Size(125, 27);
            locadressaddtextBox.TabIndex = 7;
            // 
            // locowneraddtextBox
            // 
            locowneraddtextBox.Location = new Point(392, 227);
            locowneraddtextBox.Name = "locowneraddtextBox";
            locowneraddtextBox.Size = new Size(125, 27);
            locowneraddtextBox.TabIndex = 8;
            // 
            // addlocadbutton1
            // 
            addlocadbutton1.Location = new Point(151, 347);
            addlocadbutton1.Name = "addlocadbutton1";
            addlocadbutton1.Size = new Size(94, 29);
            addlocadbutton1.TabIndex = 9;
            addlocadbutton1.Text = "Add Location";
            addlocadbutton1.UseVisualStyleBackColor = true;
            addlocadbutton1.Click += addlocadbutton1_Click;
            // 
            // addlocbackbutton2
            // 
            addlocbackbutton2.Location = new Point(553, 347);
            addlocbackbutton2.Name = "addlocbackbutton2";
            addlocbackbutton2.Size = new Size(168, 29);
            addlocbackbutton2.TabIndex = 10;
            addlocbackbutton2.Text = "Back to AdminDash Board";
            addlocbackbutton2.UseVisualStyleBackColor = true;
            addlocbackbutton2.Click += addlocbackbutton2_Click;
            // 
            // AddLocationForm2
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(addlocbackbutton2);
            Controls.Add(addlocadbutton1);
            Controls.Add(locowneraddtextBox);
            Controls.Add(locadressaddtextBox);
            Controls.Add(locnameaddtextBox);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "AddLocationForm2";
            Text = "AddLocationForm2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label3;
        private Label label4;
        private Label label5;
        private TextBox locnameaddtextBox;
        private TextBox locadressaddtextBox;
        private TextBox locowneraddtextBox;
        private Button addlocadbutton1;
        private Button addlocbackbutton2;
    }
}