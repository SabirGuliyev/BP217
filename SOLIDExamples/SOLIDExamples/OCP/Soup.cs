﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.OCP
{
    internal class Soup : IMeal
    {
        public void Cook()
        {
            Console.WriteLine("Soup is ready");
        }
    }
}