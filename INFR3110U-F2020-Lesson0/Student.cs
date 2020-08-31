using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFR3110U_F2020_Lesson0
{
    public class Student : Person
    {
        public string StudentID { get; set; }

        public Student(string firstName="", string lastName = "", int age=0, string studentID = "")
        :base(firstName, lastName, age)
        {
            this.StudentID = studentID;
        }

        public void Studies()
        {
            Console.WriteLine($"{this.FirstName} with a student ID of {this.StudentID} is studying");
        }
    }
}
