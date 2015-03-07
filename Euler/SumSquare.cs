using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class SumSquare
    {
        public static int Difference(int n)
        {
            int sum = 0;
            int square = 0;
            for (int i = 1; i <= n; i++)
            {
                sum += i;
                square += (int)Math.Pow(i, 2);
            }
            return ((int)Math.Pow(sum, 2)) - square;
        }
    }
}
