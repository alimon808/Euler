using System;
using System.Collections.Generic;

namespace Euler
{
    public class ProductInASeries
    {
        public static ulong Largest(string strN, int adjacentDigits)
        {
            int currentIndex = 0;
            ulong maxProduct = 0;

            while (currentIndex + adjacentDigits < strN.Length)
            {
                var str = strN.Substring(currentIndex, adjacentDigits);
                var product = Product(str);
                if (maxProduct < product)
                {
                    maxProduct = product;
                }
                currentIndex++;
            }
            
            return maxProduct;
        }

        private static ulong Product(string num)
        {
            ulong product = 1;
            foreach (var n in num)
            {
                int temp = int.Parse(n.ToString());
                product = product * (ulong)temp;
            }
            return product;
        }
    }
}
