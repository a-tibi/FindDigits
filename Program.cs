using System;

namespace FindDigits
{
	class Program
	{
		public static int findDigits(int n)
		{
			int result = 0;
			string digits = Convert.ToString(n);

			foreach (var digit in digits)
			{
				int d = (int) Char.GetNumericValue(digit);
				if(d > 0)
				{
					if (n % d == 0)
					{
						result++;
					}
				}
			}

			return result;
		}

		static void Main(string[] args)
		{
			int t = Convert.ToInt32(Console.ReadLine().Trim());
			int[] results = new int[t];

			for (int tItr = 0; tItr < t; tItr++)
			{
				int n = Convert.ToInt32(Console.ReadLine().Trim());

				results[tItr] = findDigits(n);
			}

			for (int i = 0; i < t; i++)
			{
				Console.WriteLine(results[i]);
			}

			Console.ReadKey();
		}
	}
}
