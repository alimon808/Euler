using System;
using System.Collections;
using System.Collections.Generic;

namespace Euler
{
	public class MultipleOfThreeAndFive
	{
		public static int Sum(int n)
		{
			var multiples = Multiples(n);
			int sum = 0;
			foreach (var m in multiples)
			{
				sum += m;
			}
			return sum;
		}

		private static List<int> Multiples(int n)
		{
			var list = new List<int>();
			for (int i = 1; i < n; i++)
			{
				if (i % 3 == 0 || i % 5 == 0)
				{
					list.Add(i);
				}
			}
			return list;
		}
	}
}
