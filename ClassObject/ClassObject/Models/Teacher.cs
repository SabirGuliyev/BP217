using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassObject.Models
{
    internal class Teacher : Person
    {


        public decimal Salary;
        public string Profession;
        public byte Experience;

        public Teacher(string name,string surname):base(name,surname)
        {
            
        }

        //public Teacher(string name, string surname,decimal salary,string prof,byte exp) : base(name, surname)
        //{
        //    Salary = salary;
        //    Profession = prof;
        //    Experience = exp;   
        //}

    }
}
