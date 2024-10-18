using InterfaceExample.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExample.Models
{
    internal class Penguin : Bird,ISwim
    {
        public int SwimSpeed { get; set ; }

        public override void MakeSound()
        {
            Console.WriteLine("Kowalski");
        }

        public void Swim()
        {
            Console.WriteLine("Penguin swam away "+SwimSpeed);
        }
    }
}
