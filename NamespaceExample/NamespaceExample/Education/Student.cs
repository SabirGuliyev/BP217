using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample.Education
{
    internal class Student
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public byte Age { get; set; }

        public void GetInfo()
        {
            Console.WriteLine($"Name:{Name} Surname:{Surname} Age:{Age}");
        }
    }
}
