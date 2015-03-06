using System;
using System.Collections;
using System.Collections.Generic;
using Euler;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class FibonacciTests
    {
        
        [Test]
        public void ShouldReturn10ForSumOfEvenFibonacciTermsThatAreLessThan10()
        {
            var sum = Fibonacci.SumOfEvenTerms(10UL);
            Assert.That(sum, Is.EqualTo(10));
        }

        [Test]
        public void ShouldReturn4613732ForSumOfEvenFibonacciThatAreLessThanFourMillion()
        {
            var sum = Fibonacci.SumOfEvenTerms(4000000UL);
            Assert.That(sum, Is.EqualTo(4613732));
        }
    }
}
