using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Models
{
    internal class Cow:Animal
    {
        public void ProduceMilk()
        {
            Console.WriteLine("Milk produced");
        }

        public override void MakeSound()
        {
            Console.WriteLine("mooooo");
        }

        //public override string ToString()
        //{
        //    return $"{AvgLifeTime} {Gender}";
        //}
    }
}
