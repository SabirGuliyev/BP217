using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeExample.Models
{
    internal class Lion:Animal
    {
        public bool IsPrime { get; set; }
        public void Roar()
        {
            Console.WriteLine("Roaaaar GS");
        }
    }
}
