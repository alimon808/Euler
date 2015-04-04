using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public class LargeSum
    {
        public double Sum(string[] ints)
        {
            double sum = 0;
            foreach (var s in ints)
            {
                sum += Convert.ToDouble(s);
            }
            return sum;
        }

        public string FirstTenNumber(string[] ints)
        {
            double sum = this.Sum(ints);
            return sum.ToString().Substring(0, 11).Replace(".", "");
        }
    }
}
