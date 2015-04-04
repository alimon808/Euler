using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    // n -> n/2 (even)
    // n -> 3n + 1 (odd)
    // break when n = 1
    public class CollatzSequence
    {
        public List<double> Compute(double n)
        {
            var sequence = new List<double>();
            while (n > 1)
            {
                sequence.Add(n);
                if (n % 2 == 0)
                {
                    n = n / 2;
                }
                else
                {
                    n = 3 * n + 1;
                }
            }
            sequence.Add(1);

            return sequence;
        }

        public double LargestSequence(double n)
        {
            double count = 0;
            double maxN = n;
            while (n > 1)
            {
                var sequence = this.Compute(n);
                if (sequence.Count > count)
                {
                    count = sequence.Count;
                    maxN = n;
                    Console.WriteLine("{0} : {1}", n, count);
                }
                n--;
            }

            return maxN;
        }
    }
}
