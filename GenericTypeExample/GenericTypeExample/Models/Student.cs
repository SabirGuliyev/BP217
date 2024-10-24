using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeExample.Models
{
    internal class Student
    {
        public string Name { get; set; }

        public void GetInfo<T>(T input)
        {
            Console.WriteLine(input);
        }
    }
}

