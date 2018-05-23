using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/// <summary>
/// this is the student class
/// </summary>

namespace COMP123_S2017_Lesson8B_Revise
{
    class Student : Person
    {
        //private instance variables
       private string _studentID;

        //public prperties
        public String StudentID
        {
            get
            {
                return this._studentID;
            }
            set
            {
                this._studentID = value;
            }
        }
        //public constructor
        /// <summary>
        /// this is a constructor for Student class
        /// this takes three arguments - name(string), age(int) and studentID(string)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public Student(string name, int age, string studentID)
            : base(name, age)
        {
            this.StudentID = studentID;
        }

        //public methods
        /// <summary>
        /// this is the Studies method
        /// enables the student to study
        /// </summary>
        public void Studies()
        {
            Console.WriteLine(this.Name + " is studying!");
        }
    }
}
