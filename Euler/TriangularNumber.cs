using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class TriangularNumber
    {
        public int Calculate(int n)
        {
            int sum = 0;
            while (n > 0)
            {
                sum += n;
                n--;
            }
            return sum;
        }

        public int CalculateNumberOfDivisors(int n)
        {
            //int a = 0;
            //for (int i = 1; i < n/2; i++)
            //{
            //    if (n % i == 0)
            //    {
            //        a++;
            //    }
            //}
            //a++;
            //return a;
            int limit = n;
            int numberOfDivisors = 0;

            for (int i = 1; i < limit; ++i) {
                if (n % i == 0) {
                    limit = n / i;
                    if (limit != i) {
                        numberOfDivisors++;
                    }
                    numberOfDivisors++;
                }
            }

            return numberOfDivisors;
        }

        public int FirstTriangleNumberForNDivisors(int n)
        {
            int sum = 0;
            int naturalNumber = 1;
            while (true)
            {
                if (CalculateNumberOfDivisors(sum) >= n)
                {
                    return sum;
                }
                else
                {
                    sum += naturalNumber;
                }
                naturalNumber++;
            }
        }
    }
}
