using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Dog : Animal
    {
      
        public string Name { get; set; }
        public string Breed { get; set; }

        public override void MakeSound()
        {
            Console.WriteLine("hav hav");
        }

        public void PlayWithHuman()
        {
            Console.WriteLine("Plays");
        }
        public override void Eat()
        {
            Console.WriteLine("vegetables and meat");
        }

        //public override string ToString()
        //{
        //    return $"Name:{Name} Breed:{Breed}";
        //}
    }
}
