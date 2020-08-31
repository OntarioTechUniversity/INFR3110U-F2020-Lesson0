using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFR3110U_F2020_Lesson0
{
    public abstract class Person
    {
        // private instance variables
        private string m_firstName;

        // public properties
        public string FirstName
        {

            get
            {
                return this.m_firstName;
            }

            set
            {
                this.m_firstName = value;
            }
        }

        public string LastName { get; set; }
        public int Age { get; set; }

        // Constructor

        public Person(string firstName="", string lastName = "", int age = 0)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;
        }

        // private methods

        // public methods
        public void SaysHello()
        {
            Console.WriteLine($"{this.FirstName} says hello!");
        }

    }
}
