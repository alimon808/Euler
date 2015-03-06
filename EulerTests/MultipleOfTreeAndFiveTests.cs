using System;
using Euler;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class MultipleOfTreeAndFiveTests
    {
        // 3, 5, 6, 9, 10, 12 = 60
        [Test]
        public void ShouldReturn45ForSumOf15()
        {
            var sum = MultipleOfThreeAndFive.Sum(15);
            Assert.That(sum, Is.EqualTo(45));
        }

        [Test]
        public void ShouldReturn233168ForSumOf1000()
        {
            var sum = MultipleOfThreeAndFive.Sum(1000);
            Assert.That(sum, Is.EqualTo(233168));
        }
    }
}
