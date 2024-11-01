using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Liskov
{
    internal class Eagle : Bird, IFly
    {
        public int FlySpeed { get; set ; }
       

        public override void Eat()
        {
            if (Age < 5)
            {
                Console.WriteLine("Warms");
            }
            else
            {
                Console.WriteLine("Meat");
            }
        }
        public void Fly()
        {
           
            Console.WriteLine("Flied away");
        }

      
    }
}
