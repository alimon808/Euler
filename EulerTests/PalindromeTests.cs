using System;
using System.Collections.Generic;
using NUnit.Framework;
using Euler;

namespace EulerTests
{
    [TestFixture]
    public class PalindromeTests
    {
        [Test]
        public void ShouldReturnLargestPalindrome()
        {
            var palindrome = Palindrome.Largest(3);
            Assert.That(palindrome, Is.EqualTo(906609));
        }

        [Test]
        public void ShouldReturnValidPalindrome()
        {
            bool result = EulerHelper.IsPalindrome(121);
            Assert.That(result, Is.True);
        }

        [Test]
        public void ShouldReturnInValidPalindrome()
        {
            bool result = EulerHelper.IsPalindrome(123);
            Assert.That(result, Is.False);
        }
    }
}
