using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCexsample
{
    public class StudentContaller
    {
        public Form1 view;
        public List<Student> students;
        public int Id;

        public StudentContaller(Form1 view)
        {
            this.view = view;
            students = new List<Student>();
            Id = 1;
        }

        public void Addstudent(string name, int age)
        {
            Student newStudent = new Student(Id++, name, age);
            students.Add(newStudent);
            view.Displaystudent(students);
        }

        
    }
}
