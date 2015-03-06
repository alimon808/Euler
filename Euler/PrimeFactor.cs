using System;
using System.Collections.Generic;

namespace Euler
{
    public class PrimeFactor
    {
        public static ulong Largest(ulong n)
        {
            var lpf = 0UL;
            for (ulong i = 2; i <= n; i++)
            {
                if (EulerHelper.IsPrime(i))
                {
                    while ((n % i) == 0)
                    {
                        n = n / i;
                    }
                    lpf = i;
                }
            }
            return lpf;
        }
    }
}
