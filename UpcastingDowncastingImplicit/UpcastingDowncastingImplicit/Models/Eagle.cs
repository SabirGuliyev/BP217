﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingImplicit.Models
{
    internal class Eagle:Animal
    {
        public int FlySpeed { get; set; }
        public void Fly()
        {
            Console.WriteLine("Flied away");
        }
    }
}
