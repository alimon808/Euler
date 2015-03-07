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
            var list = new List<int[]>();

            int c = 997;
            int b = 2;
            int a = 1;
            while (b < c)
            {
                while (a < b)
                {
                    if ((Math.Pow(a, 2) + Math.Pow(b, 2)) == Math.Pow(c, 2))
                    {
                        list.Add(new[] { a, b, c });
                    }
                    a++;
                    c--;
                }
                c = c + a - 2;
                a = 1;
                b++;
            }

            foreach (var item in list)
            {
                Console.WriteLine("a={0}, b={1}, c={2}", item[0], item[1], item[2]);
                Console.WriteLine(item[0] * item[1] * item[2]);
            }
            Assert.That(list.Count, Is.EqualTo(1));

            var abc = list[0][0] * list[0][1] * list[0][2];
            Assert.That(abc, Is.EqualTo(31875000));
        }
    }
}
