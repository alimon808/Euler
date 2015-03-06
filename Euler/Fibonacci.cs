using System;
using System.Collections;
using System.Collections.Generic;

namespace Euler
{
    public class Fibonacci
    {
        public static ulong SumOfEvenTerms(ulong n)
        {
            var sequence = Sequence(n);
            ulong sum = 0UL;
            foreach (var num in sequence)
            {
                if (num % 2 == 0)
                {
                    sum += num;
                }
            }
            return sum;
        }

        public static List<ulong> Sequence(ulong n)
        {
            var sequence = new List<ulong>(){1UL, 2UL};
            var sum = 0UL;
            while (sum < n)
            {
                var count = sequence.Count;
                sum = sequence[sequence.Count - 1] + sequence[sequence.Count - 2];
                sequence.Add(sum);
            }
            return sequence;
        }
    }
}
