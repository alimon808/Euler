using System;
using System.Collections;
using System.Collections.Generic;

namespace Euler
{
    public class ProductInGrid
    {
        public static ulong Largest(int[,] grid)
        {
            ulong largest = 0;
            ulong product = 0;
            product = HorizontalProduct(grid);
            if (largest < product)
            {
                largest = product;
            }

            product = VerticalProduct(grid);
            if (largest < product)
            {
                largest = product;
            }


            return largest;
        }

        private static ulong HorizontalProduct(int[,] grid)
        {
            Queue<int> queue = new Queue<int>();
            ulong horizontalProduct = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    queue.Enqueue(grid[i, j]);
                    if (queue.Count == 4)
                    {
                        var product = Product(queue);
                        if (horizontalProduct < product)
                        {
                            horizontalProduct = product;
                        }
                        queue.Dequeue();
                    }
                }
                queue.Clear();
            }
            return horizontalProduct;
        }

        private static ulong VerticalProduct(int[,] grid)
        {
            Queue<int> queue = new Queue<int>();
            ulong verticalProduct = 0;
            for (int i = 0; i < grid.GetLength(1); i++)
            {
                for (int j = 0; j < grid.GetLength(0); j++)
                {
                    queue.Enqueue(grid[j, i]);
                    if (queue.Count == 4)
                    {
                        var product = Product(queue);
                        if (verticalProduct < product)
                        {
                            verticalProduct = product;
                        }
                        queue.Dequeue();
                    }
                }
                queue.Clear();
            }
            return verticalProduct;
        }

        private static ulong DiagonalProduct(int[,] grid)
        {
            Queue<int> queue = new Queue<int>();
            ulong diagonalProduct = 0;
            for (int i = 0; i < grid.GetLength(0); i++)
            {
                for (int j = 0; j < grid.GetLength(1); j++)
                {
                    queue.Enqueue(grid[i, j]);
                    if (queue.Count == 4)
                    {
                        var product = Product(queue);
                        if (diagonalProduct < product)
                        {
                            diagonalProduct = product;
                        }
                        queue.Dequeue();
                    }
                }
                queue.Clear();
            }
            return diagonalProduct;
        }

        private static ulong Product(Queue<int> queue)
        {
            ulong product = 1;
            foreach (var q in queue)
            {
                product = product * (ulong)q;
            }

            return product;
        }
    }
}
