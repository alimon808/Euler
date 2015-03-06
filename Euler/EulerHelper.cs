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
            for (ulong i = 5; i * i <= n; i+=6)
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
            int firstIndex= 0;
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
    }
}
