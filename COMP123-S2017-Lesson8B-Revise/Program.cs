using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8B_Revise
{
    class Program
    {
        static void Main(string[] args)
        {
            //helps drive rest of the code
            Person person = new Person("Bishnu", 20);
            Console.WriteLine("++++++++++++++++++++++++++++++");
            person.Talks();
            Console.WriteLine("++++++++++++++++++++++++++++++");
            Console.WriteLine("\n");
            Student student = new Student("Bobo", 25, "123456789A");
            student.Studies();
            student.Talks();
            Console.WriteLine("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");

            DomesticStudent domestic = new DomesticStudent("Mary", 25, "123456888A");
            domestic.Studies();
            domestic.Talks();
            Console.WriteLine("\n");
            Console.WriteLine("++++++++++++++++++++++++++++++");
        }
    }
}
