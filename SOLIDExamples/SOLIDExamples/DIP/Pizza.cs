using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.DIP
{
    internal class Pizza
    {
        ICut Tool;
        public Pizza(ICut tool)
        {
                Tool = tool;
        }

        public void CutPizza()
        {
            Tool.Cut();
        }
    }
}
