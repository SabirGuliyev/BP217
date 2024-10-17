using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Humanity
{
    internal abstract class Person
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }

        public virtual string GetInfo()
        {
            return $"{Name} {Surname} {Age}";
        }
        public sealed override string ToString()
        {
            return $"{Name} {Surname}";
        }

    }
}
