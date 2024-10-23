using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingImplicit.Models
{
    internal class Dog:Animal
    {
        public string Name { get; set; }
        public string Breed { get; set; }

        public DateTime CreatedAt { get;  }

        public Dog()
        {
            //CreatedAt 
        }
        ~Dog()
        {
            Console.WriteLine("Object destructed");

        }


    }
}
