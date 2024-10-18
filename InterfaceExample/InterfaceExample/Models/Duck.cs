using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Duck : Bird,ISwimFly
    {
        public int SwimSpeed { get ; set ; }
        public int FlySpeed { get ; set; }

        public void Fly()
        {
            Console.WriteLine("Duck flied");
        }

        public override void MakeSound()
        {
            Console.WriteLine("Vagk");
        }

        public void Swim()
        {
            Console.WriteLine("Duck swam away");
        }
    }
}
