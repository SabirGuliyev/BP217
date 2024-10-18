using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Humanity
{
    internal class Person
    {

        //public static int WorkAge { get; set; } = 18;

        private static int s_count=0;
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        //static Person()
        //{
        //    Console.WriteLine("Static ctor ishe dushdu");
        //}
        public Person()
        {
            Id = ++s_count;

            //_count++;
            //Id =_count ;


            //Id= _count ;
            //_count++;

        }
        public void GetInfo() //Non-static
        {
            Console.WriteLine($"{Name} {Surname}");
        }

        public static string Capitalize(string name)//static
        {

           
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }
    }
}
