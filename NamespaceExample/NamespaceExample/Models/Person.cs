using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NamespaceExample.Models
{
    internal class Person
    {
        public const string WifiPass="Salam123";
        public int Id { get; init; } = 12;

        public readonly string Surname="Quliyev";

        private int _age;

        public int Age
        {
            get { return _age; }

        } 

        //Get only Auto property // Read-only
        public string Name { get; } = "Salam";

        public Person(string name, int age, string surname, int id,string tes)
        {
            Name = name;
            _age = age;
            Surname = surname;
            Id = id;
            

        }
    }
   
}
