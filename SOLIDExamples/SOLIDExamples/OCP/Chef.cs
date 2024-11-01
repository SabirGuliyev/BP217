using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.OCP
{
    internal class Chef
    {
        public void MakeMeal(IMeal meal)
        {
            meal.Cook();
        }
    }
}
