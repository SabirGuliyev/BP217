using AbstractExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractExample.Humanity
{
    internal class Master:Student
    {
        public string Diplom { get; set; }
        public string MasterUni { get; set; }

        public override string GetInfo()
        {
            return string.Concat(base.GetInfo(), " ", $"{Diplom} {MasterUni}");
        }
    }
}
