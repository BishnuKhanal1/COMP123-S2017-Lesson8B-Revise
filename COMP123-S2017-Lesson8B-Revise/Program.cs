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
        }
    }
}
