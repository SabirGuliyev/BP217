using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeExample.Models
{
    //Generic constraints
    internal class ZooCage<T,U> where T : Animal,new()
                                where U :Food,new()
    {
        public string CageNO { get; set; }

        public T[] Animals=new T[0];

        public U Food;

        public ZooCage(U food)
        {
            Food=food;

        }
        public void Add(T animal)
        {
            Array.Resize(ref Animals, Animals.Length + 1);
            Animals[Animals.Length-1] = animal;
        }


        public void ShowAnimals()
        {
            foreach (T animal in Animals) 
            {
                Console.WriteLine(animal.Name);
            }
        }
    }
}
