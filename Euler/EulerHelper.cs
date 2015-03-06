using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class EulerHelper
    {
        public static bool IsPrime(ulong n)
        {
            if (n <= 3)
            {
                return n > 1;
            }
            else if (n % 2 == 0 || n % 3 == 0)
            {
                return false;
            }
            for (ulong i = 5; i * i <= n; i += 6)
            {
                if (n % i == 0 || n % (i + 2) == 0)
                {
                    return false;
                }
            }
            return true;
        }

        public static bool IsPalindrome(ulong n)
        {
            var arr = n.ToString().ToCharArray();
            int firstIndex = 0;
            int lastIndex = arr.Length - 1;

            while (firstIndex < lastIndex)
            {
                if (arr[firstIndex] != arr[lastIndex])
                {
                    return false;
                }
                firstIndex++;
                lastIndex--;
            }

            return true;
        }

        public static ulong SmallestMultipleBruteForce(ulong n)
        {
            ulong smallestMultiple = n;
            for (ulong i = n; i > 1; i--)
            {
                if (smallestMultiple % i != 0)
                {
                    smallestMultiple++;
                    i = n + 1;
                }
            }
            return smallestMultiple;
        }

        public static int SmallestMultiple(int k)
        {
            int N = 1;
            int i = 1;
            bool check = true;
            var limit = Math.Sqrt(k);
            int[] primes = new int[]{1, 2, 3, 5, 7, 11, 13, 17, 19, 23};
            int[] a = new int[9];
            while (primes[i] <= k)
            {
                a[i] = 1;
                if (check)
                {
                    if (primes[i] <= limit)
                    {
                        a[i] = (int)Math.Floor(Math.Log(k) / Math.Log(primes[i]));
                    }
                    else
                    {
                        check = false;
                    }
                }
                N = N * (int)Math.Pow(primes[i], a[i]);
                i = i + 1;
            }
            return N;
        }
    }
}
