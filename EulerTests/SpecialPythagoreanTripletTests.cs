using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class SpecialPythagoreanTripletTests
    {
        [Test]
        public void ShouldReturnOneTriplet()
        {
            var list = Euler.Pythagorean.Triplets(1000);

            foreach (var item in list)
            {
                Console.WriteLine("a={0}, b={1}, c={2}", item[0], item[1], item[2]);
                Console.WriteLine(item[0] * item[1] * item[2]);
            }
            Assert.That(list.Count, Is.EqualTo(1));

            var abc = list[0][0] * list[0][1] * list[0][2];
            Assert.That(abc, Is.EqualTo(31875000));
        }

        //[Test]
        //public void ShouldReturnPythagoreanTriplet()
        //{

        //}
    }
}
