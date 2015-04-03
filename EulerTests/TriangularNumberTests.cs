using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Euler;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class TriangularNumberTests
    {
        [TestCase(4, 10)]
        [TestCase(6, 21)]
        [TestCase(7, 28)]
        public void ShouldTestTheFirstSevenTriagularNumbers(int n, int expected)
        {
            var triangularNumber = new TriangularNumber();
            var result = triangularNumber.Calculate(n);
            Assert.That(result, Is.EqualTo(expected));
        }

        [Test]
        public void ShouldTestNumberOfDivisorsForTriangularNumber()
        {
            var triangularNumber = new TriangularNumber();
            var result = triangularNumber.CalculateNumberOfDivisors(28);
            Assert.That(result, Is.EqualTo(6));
        }

        [Test]
        public void ShouldTestFirstTriangularNumberWithFiveDivisors()
        {
            var triangularNumber = new TriangularNumber();
            var result = triangularNumber.FirstTriangleNumberForNDivisors(5);
            Assert.That(result, Is.EqualTo(28));
        }

        [Test]
        public void ShouldTestFirstTriangularNumberWithFiveHundredDivisors()
        {
            var triangularNumber = new TriangularNumber();
            var result = triangularNumber.FirstTriangleNumberForNDivisors(500);
            Assert.That(result, Is.EqualTo(76576500));
        }
    }
}
