using System;
using System.Collections.Generic;
using System.Text;

namespace Hodina
{
    public class Divisor
    {
        public static ulong GCD(ulong a, ulong b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b)
                    a = a % b;
                else
                    b = b % a;
            }

            return a | b;
        }
    }
}
