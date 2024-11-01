using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Liskov
{
    internal abstract class Bird
    {
        public int Age { get; set; }
        public virtual void  Eat()
        {
            Console.WriteLine("Eat");
        }

        //public virtual void Fly() {
        //    Console.WriteLine("Flied away");
        //}
    }
}
