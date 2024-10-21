using NullableStructEnum.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableStructEnum.Models
{
    internal class Person
    {
        public string Name { get; set; }
        public Gender Gender { get; set; }
        public Person(Gender gender)
        {
            Gender=gender;
        }
    }
}
