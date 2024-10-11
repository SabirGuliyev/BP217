using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject.Models
{
    internal class Student:Person
    {
        public string UniName;
        public byte Grade;
        public string Faculty;

        public Student(string name, string surname) : base(name, surname)
        {

        }
    }
}
