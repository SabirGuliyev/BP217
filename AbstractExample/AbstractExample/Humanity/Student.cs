using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Humanity
{
    internal class Student:Person
    {
        public string GroupName { get; set; }

        public int Grade { get; set; }

        new public virtual string GetInfo()
        {
            return $"{Name} {Surname} {Age} {GroupName} {Grade}"; ;
        }
        //public override string GetInfo()
        //{
        //    return string.Concat(base.GetInfo(), " ", $"{GroupName} {Grade}");
        //}
    }
}
