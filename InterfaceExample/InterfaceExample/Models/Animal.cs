using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal abstract class Animal
    {
        public int AvgLifeTime { get; set; }
        public string Gender { get; set; }
        protected Animal()
        {
            
        }
        public abstract void MakeSound();

        public virtual void Eat()
        {
            Console.WriteLine("Eat Grass");
        }


    }
}
