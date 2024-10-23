using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingImplicit.Exchanges
{
    internal class Manat
    {
        public decimal AZN { get; set; }
        public Manat(decimal azn)
        {
            AZN = azn;
        }



        public static bool operator ==(Manat manat,Manat manat2)
        {
            return manat.AZN==manat2.AZN;
        }

        public static bool operator !=(Manat manat,Manat manat2)
        {
            return manat.AZN != manat2.AZN;
        }

        public static bool operator >(Manat manat,Manat manat2)
        {
            return manat.AZN>manat2.AZN;
        }
        public static bool operator <(Manat manat, Manat manat2)
        {
            return manat.AZN < manat2.AZN;
        }


        public static Manat operator +(Manat manat,Manat manat2)
        {
            manat.AZN += manat2.AZN;
            return manat;
        }

        public static Manat operator +(Manat manat, decimal value)
        {
            manat.AZN += value;
            return manat;
        }

        public override string ToString()
        {
            return AZN.ToString();
        }






        public static implicit operator Manat(decimal value)
        {
            return new Manat(value);
        }

        public static implicit operator Manat(Dollar dollar)
        {
            return new Manat(dollar.USD * 1.7m);
        }

    }
}
