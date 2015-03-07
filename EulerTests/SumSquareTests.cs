using System;
using System.Collections.Generic;
using Euler;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class SumSquareTests
    {
        [TestCase(10, 2640)]
        [TestCase(100, 25164150)]
        public void ShouldTestSumSquareDifference(int n, int expected)
        {
            var difference = SumSquare.Difference(n);
            Assert.That(difference, Is.EqualTo(expected));
        }
    }
}
