using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace COMP123_S2017_Lesson8B_Revise
{
  public  class Person
    {
        //private instance variables
        private string _name;
        private int _age;

        //public properties
        public string Name
        {
            get
            {
                return this._name;
            }
            set
            {
                this._name = value;
            }
        }

        public int Age
        {
            get
            {
                return this._age;
            }
            set
            {
                this._age = value;
            }
        }
        //constructor
        /// <summary>
        /// This is the constructor for the person class 
        /// It takes 2 arguments name (string) and age(int)
        /// </summary>
        /// <param name="name"></param>
        /// <param name="age"></param>
        public Person(string name, int age)
        {
            //use properties here
            //constructors get triggured when I create my object
            this.Name = name;
            this.Age = age;
        }
        //public methodd
        /// <summary>
        /// this method allows the person to talk
        /// </summary>
        public void Talks()
        {
            Console.WriteLine(this.Name + " is talking");
        }
    }
}
