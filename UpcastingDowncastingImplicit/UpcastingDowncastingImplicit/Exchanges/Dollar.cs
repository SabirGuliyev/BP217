using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UpcastingDowncastingImplicit.Exchanges
{
    internal class Dollar
    {
        public decimal USD { get; set; }
        public Dollar(decimal usd)
        {
            USD = usd;
        }
        public static implicit operator Dollar(Manat manat)
        {
            return new Dollar(manat.AZN / 1.7m);
        }

       
        //public static explicit operator Dollar(Manat manat)
        //{
        //    return new Dollar(manat.AZN / 1.7m);
        //}

        //public static explicit operator Manat(Dollar dollar)
        //{
        //    return new Manat(dollar.USD * 1.7m);
        //}



    }
}
