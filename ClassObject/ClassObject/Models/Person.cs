using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject.Models
{
    class Person
    {
        //Fields

        public string Name;
        public string Surname;
        public byte Age;
        public bool IsSingle;


       
        public Person(string name,string surname)
        {

            Console.WriteLine("Person ctor ishe dushdu");
        }
        #region Ctor Overloads

        //public Person()
        //{
        //    Console.WriteLine("Person created");
        //}

        //public Person(string name):this()
        //{

        //    Name = name;
        //}
        //public Person(string name, string surname):this( name )
        //{

        //    Surname = surname;
        //}
        //public Person(string name, string surname, byte age):this(name,surname)
        //{

        //    Age = age;
        //}
        //public Person(string name,string surname,byte age,bool isSingle):this(name,surname,age)
        //{

        //    IsSingle= isSingle;

        //}

        #endregion


        //Methods

        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age} Is single:{IsSingle}");

        }

    }
}
