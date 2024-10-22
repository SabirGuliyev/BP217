using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClassException
{
    public static class Helper
    {
        
        private static string OffEmail = "code@edu.az";
        public static string Capitalize(this string name)
        {
            return name.Substring(0, 1).ToUpper() + name.Substring(1).ToLower();
        }

        public static int Power(this int num)
        {
            
            return num * num;
        }
        public static int Power(this int num,int power)
        {
            int result = 1;
            for (int i = 1; i <= power; i++)
            {
                result *= num;
            }
            return result;
        }
    }
}
