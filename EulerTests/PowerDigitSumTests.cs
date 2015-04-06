using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class PowerDigitSumTests
    {
        [Test]
        public void ShouldSumTwoToThePowerOfFifteen()
        {
            double val = Math.Pow(2, 15);
            int sum = 0;
            foreach (var c in val.ToString())
            {
                sum += (int)Char.GetNumericValue(c);
                //Console.WriteLine("{0} : {1}", c, sum);
            }
            Assert.That(sum, Is.EqualTo(26));
        }

        // Problem 16: Power digit sum
        [Test]
        public void ShouldSumTwoToThePowerOfOneThousand()
        {
            BigInteger val = (BigInteger)Math.Pow(2, 1000);
            int sum = 0;
            foreach (var c in val.ToString())
            {
                sum += (int)Char.GetNumericValue(c);
            }
            //Console.WriteLine(sum);
            Assert.That(sum, Is.EqualTo(1366));
        }
    }
}
