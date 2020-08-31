using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace INFR3110U_F2020_Lesson0
{
    class Program
    {
        static void Main(string[] args)
        {
            var tom = new Student("Tom");
            tom.LastName = "Tsiliopoulos";
            tom.Age = 30;
            tom.StudentID = "A123456789";

            tom.SaysHello();
            tom.Studies();


            Console.ReadKey();
        }
    }
}
