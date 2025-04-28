namespace MVCexsample
{
    public partial class Form1 : Form
    {
        public StudentContaller contallerobject;
        public Form1()
        {
            InitializeComponent();
            contallerobject = new StudentContaller(this);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtstudentname_TextChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            string name = txtstudentname.Text;
            MessageBox.Show(name);

            int age = Convert.ToInt32(txtstudentage.Text);
            MessageBox.Show(name + " " + age);

            contallerobject.Addstudent(name, age);
        }

        public void Displaystudent(List<Student> students)
        {
            StudentlistBox.Items.Clear();
            foreach (Student student in students)
            {
                StudentlistBox.Items.Add($"{student.Id}. {student.Name} {student.Age}");
            }

        }

        private void txtstudentage_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
