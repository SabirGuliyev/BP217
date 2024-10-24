using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericTypeExample.Models
{
    //internal class Product
    //{
    //    public object Quality { get; set; }

    //    public Product(object quality)
    //    {
    //        Quality = quality;
    //    }

    //}
    internal class Product<T>
    {
        public T Quality { get; set; }

        public Product(T quality)
        {
            Quality = quality;
        }
        public void GetInfo(T test)
        {
            
        }

    }
}
