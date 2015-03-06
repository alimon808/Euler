using System;
using System.Collections.Generic;

namespace Euler
{
    public class Palindrome
    {
        public static ulong Largest(int degree)
        {
            ulong upperBound = (ulong)Math.Pow(10, degree) - 1;
            ulong max = upperBound * upperBound;

            for (ulong i = max; i > 0; i--)
            {
                if (EulerHelper.IsPalindrome(i))
                {
                    for (ulong j = upperBound; j > 100; j--)
                    {
                        if (i % j == 0 && (i / j < upperBound + 1))
                        {
                            //Console.WriteLine("x1={0}, x2={1}", j, i/j);
                            return i;
                        }
                    }
                }
            }
            return 0;
        }
    }
}
