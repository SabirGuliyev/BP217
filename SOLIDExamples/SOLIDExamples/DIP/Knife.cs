using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.DIP
{
    internal class Knife:ICut
    {
        public Knife()
        {
            throw new Exception("Qirilib");
        }

        public void Cut()
        {
            Console.WriteLine("Item was cut");
        }
    }
}
