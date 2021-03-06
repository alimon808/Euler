﻿using System;
using System.Collections.Generic;
using Euler;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class PrimeFactorTests
    {
        [Test]
        public void ShouldReturn29For13195()
        {
            var largetPrimeFactor = PrimeFactor.Largest(13195);
            Assert.That(largetPrimeFactor, Is.EqualTo(29));
        }   

        [Test]
        public void ShouldReturn6857For600851475143()
        {
            var largetPrimeFactor = PrimeFactor.Largest(600851475143);
            Assert.That(largetPrimeFactor, Is.EqualTo(6857));
        }

        [TestCase(10, 17UL)]
        [TestCase(2000000, 142913828922UL)]
        public void ShouldReturnSumOfPrimes(int n, ulong expected)
        {
            var sum = PrimeFactor.SumOfPrimes(n);
            Assert.That(sum, Is.EqualTo(expected));
        }
    }
}
