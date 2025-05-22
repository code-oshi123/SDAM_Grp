using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Adminloginform
{
    public partial class Homepage : Form
    {
        public Homepage()
        {
            InitializeComponent();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {

            {
                string username = username_tb.Text;
                string password = password_tb.Text;

               
                if (username == "admin" && password == "admin123")
                {
                
                    MessageBox.Show("Welcome, Admin!", "Login Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    
                    Homepage homepage = new Homepage();
                    homepage.Show();
                    this.Hide();
                }
                else
                {
                    // error message
                    MessageBox.Show("Incorrect username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
