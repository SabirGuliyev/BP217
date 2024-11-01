using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Liskov
{
    internal class Duck : Bird, IFlySwim
    {
        public int FlySpeed { get ; set ; }
        public int SwimSpeed { get; set ; }

        public void Fly()
        {
            Console.WriteLine("Flied away");
        }

        public void Swim()
        {
            Console.WriteLine("Swam away");
        }
    }
}
