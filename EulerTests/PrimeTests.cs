using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class PrimeTests
    {
        [TestCase(6)]
        [TestCase(10001)]
        public void ShouldReturnTheNthPrime(int n)
        {
            var count = 0;
            var prime = 1;
            var i = 1;
            while (count != n)
            {
                i++;
                if (Euler.EulerHelper.IsPrime((ulong)i))
                {
                    prime = i;
                    count++;
                }
            }
            Console.WriteLine(prime);
        }
    }
}
