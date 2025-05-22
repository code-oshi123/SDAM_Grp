using MySql.Data.MySqlClient;

namespace Dbex
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void checkbtn_Click(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;uid=root;pwd=;database=testdatabase";
            MySqlConnection conn = new MySqlConnection(connectionString);


            using (conn)
                try
                {
                    {
                        conn.Open();
                        conn.Close();
                        MessageBox.Show("It works");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

        }

        private void txtname_TextChanged(object sender, EventArgs e)
        {

        }

        private void loginbtn_Click(object sender, EventArgs e)
        {
            string username = txtname.Text;
            string password = txtpass.Text;

            string connectionstring = "server=localhost;uid=root;pwd=;database=testdatabase";
            MySqlConnection conn = new MySqlConnection(connectionstring);
            conn.Open();
            
            string query1 = "SELECT COUNT(*) FROM usertable WHERE username = @username and password = @Password";

            MySqlCommand cmd1 = new MySqlCommand(query1,conn);
            cmd1.Parameters.AddWithValue("@Username" , username);
            cmd1.Parameters.AddWithValue("@Password", password);

            int usercount = Convert.ToInt32(cmd1.ExecuteScalar());
            conn.Close();

            if (usercount > 0)
            {
                MessageBox.Show("login Successful");
                MenuForm menu = new MenuForm();
                menu.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("WrongUsername Or password");
            }


        }
    }
}
