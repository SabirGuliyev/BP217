using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal abstract class Animal
    {

        public int AvgLifeTime { get; set; }
        public string Gender { get; set; }

        protected Animal()
        {
            //Console.WriteLine("Animal ctor ishe dushdu");
        }
        public  abstract void MakeSound();
        
        public  virtual void Eat()
        {
            Console.WriteLine("Eat grass");
        }

        public sealed override string ToString()
        {
            return $"{AvgLifeTime} animaldanki override";
        }
    }
}
