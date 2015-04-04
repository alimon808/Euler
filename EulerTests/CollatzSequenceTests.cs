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
    public class CollatzSequenceTests
    {
        [Test]
        public void ShouldReturnTenTermsForNEqualThirteen()
        {
            var max = 13;
            var sut = new CollatzSequence();
            List<double> sequence = sut.Compute(max);
            Assert.That(sequence.Count, Is.EqualTo(10));
            //Console.WriteLine(sequence.Count);
            //foreach (var item in sequence)
            //{
            //    Console.WriteLine(item);
            //}
        }

        [Test]
        public void ShouldTestMaxNUnderOneMillion()
        {
            var n = 837799;
            var sut = new CollatzSequence();
            List<double> sequence = sut.Compute(n);
            Assert.That(sequence.Count, Is.EqualTo(525));
            foreach (var item in sequence)
            {
                Console.WriteLine(item);
            }
        }

        [Test]
        public void ShouldReturnTheLargestSequenceCountForForANumberBelowOneMillion()
        {
            var n = 1000000;
            var sut = new CollatzSequence();
            var result = sut.LargestSequence(n);
            Console.WriteLine(result);
            Assert.That(result, Is.EqualTo(837799));
        }
    }
}
