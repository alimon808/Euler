using System;
using System.Collections.Generic;

namespace Euler
{
    public class Pythagorean
    {
        public static List<int[]> Triplets(int n)
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

            return list;
        }

        //public static List<int[]> Triplets2(int n)
        //{
        //    int a = 0;
        //    int b = 0;
        //    int c = 0;
        //    var k = 0;
        //    var sm = 0;
        //    var list = new List<int[]>();
        //    var n2 = n / 2;
        //    var mLimit = Math.Ceiling(Math.Abs(Math.Sqrt(n2))) - 1;
        //    for (int m = 2; m < mLimit; m++)
        //    {
        //        if (n2 % m == 0)
        //        {
        //            sm = n2 / m;
        //            while (sm % 2 == 0)
        //            {
        //                sm = sm / 2;
        //            }

        //            if (m % 2 == 1)
        //            {
        //                k = m + 2;
        //            }
        //            else
        //            {
        //                k = m + 1;
        //            }

        //            while (k < 2 * m && k <= sm)
        //            {
        //                if (sm % k == 0 && GCD(k, m) == 1 )
        //                {
        //                    var d = n2 / (k * m);
        //                    n = k - m;
        //                    a = d * (m * m - n * n);
        //                    b = 2 * d * m * n;
        //                    c = d * (m * m + n * n);
        //                    Console.WriteLine("{0}, {1}, {2}", a, b, c);
        //                    list.Add(new[] { a, b, c });
        //                }
        //                k = k + 2;
        //            }
        //        }
        //    }
        //    return list;
        //}

        //private static int GCD(int k, int m)
        //{

        //    return 1;
        //}
    }
}
