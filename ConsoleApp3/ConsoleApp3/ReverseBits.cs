using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class ReverseBits
    {
        public static bool reverseBits(int n)
        {
            if (n == 1) return true;
            if (n <= 0) return false;
            
            double xn = n;
           while(xn >1)
            {
                xn = xn / 2;
                if(xn%1 != 0 ) return false;
            }
           return true;
            
        }
    }
}
