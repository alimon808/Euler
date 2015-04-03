using System;
using System.Collections.Generic;
using Euler;
using NUnit.Framework;

namespace EulerTests
{
    [TestFixture]
    public class ProductInGridTests
    {
        [Test]
        public void ShouldReturn24()
        {
            int[,] grid = new int[,] { { 1, 2, 3, 4 } };
            var largest = ProductInGrid.Largest(grid);
            Assert.That(largest, Is.EqualTo(24));
        }

        [TestCase(120)]
        public void ShouldReturn120(int expected)
        {
            int[,] grid = new int[,] { { 1, 2, 3, 4, 5} };
            var largest = ProductInGrid.Largest(grid);
            Assert.That(largest, Is.EqualTo(expected));
        }

        [TestCase(120)]
        public void ShouldReturnHorizonal120(int expected)
        {
            int[,] grid = new int[5,5] {{ 1, 2, 3, 4, 5 },
                                        { 1, 1, 1, 1, 1 },
                                        { 1, 1, 1, 1, 1 },
                                        { 1, 1, 1, 1, 1 },
                                        { 1, 1, 1, 1, 1 }};
            var largest = ProductInGrid.Largest(grid);
            Assert.That(largest, Is.EqualTo((ulong)expected));
        }

        [TestCase(360)]
        public void ShouldReturnVertical120(int expected)
        {
            int[,] grid = new int[5, 5] {{ 1, 1, 1, 1, 2 },
                                        { 1, 1, 1, 1, 3 },
                                        { 1, 1, 1, 1, 4 },
                                        { 1, 1, 1, 1, 5 },
                                        { 1, 1, 1, 1, 6 }};
            var largest = ProductInGrid.Largest(grid);
            Assert.That(largest, Is.EqualTo((ulong)expected));
        }
    }
}
