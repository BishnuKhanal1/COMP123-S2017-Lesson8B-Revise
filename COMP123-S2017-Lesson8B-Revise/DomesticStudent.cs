using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace COMP123_S2017_Lesson8B_Revise
{
    public class DomesticStudent : Student
    {

        //public property
        public string DomesticAddress{ get; private set; } //read only

        //constructor
        /// <summary>
        /// this is the constructor for DomesticStudent class
        /// takes three arguments
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        /// <param name="studentID"></param>
        public DomesticStudent(string name, int age, string studentID)
            : base(name, age, studentID)
        {

        }
        //public methods
        /// <summary>
        /// this is a SetDomestic() method which sets the DomesticAddress property
        /// </summary>
        public void SetDomesticAddress(string address)
        {
            this.DomesticAddress = address;
        }

    }
}