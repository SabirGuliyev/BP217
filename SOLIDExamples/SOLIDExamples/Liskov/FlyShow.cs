using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SOLIDExamples.Liskov
{
    internal class FlyShow<T> where T : Bird, IFly,new()
    {
        T bird=new T();

        public void StartShow()
        {
            bird.Fly();
        }
    }
}
