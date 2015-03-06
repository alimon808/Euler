using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class SmallestMultipleTests
    {
        [Test]
        public void ShouldReturnSmallestMultipleUsingBruteForce()
        {
            var smallestMultiple = Euler.EulerHelper.SmallestMultipleBruteForce(10);
            Console.WriteLine(smallestMultiple);
            Assert.That(smallestMultiple, Is.EqualTo(2520));

            smallestMultiple = Euler.EulerHelper.SmallestMultipleBruteForce(20);
            Console.WriteLine(smallestMultiple);
            Assert.That(smallestMultiple, Is.EqualTo(232792560));
        }

        [Test]
        public void ShouldReturnSmallestMultiple()
        {
            var smallestMultiple = Euler.EulerHelper.SmallestMultiple(10);
            Console.WriteLine(smallestMultiple);
            Assert.That(smallestMultiple, Is.EqualTo(2520));

            smallestMultiple = Euler.EulerHelper.SmallestMultiple(20);
            Console.WriteLine(smallestMultiple);
            Assert.That(smallestMultiple, Is.EqualTo(232792560));
        }
    }
}
