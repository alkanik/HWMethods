using System;
namespace HWMethods
{
	public class CyclesController
	{
		public static int Exponentiate(int a, int b)
		{
			int tmp = 1;
			int result = 1;

			while (tmp <= b)
			{
				result = result * a;
				tmp++;
			}
            return result;
		}

		public static int[] GetNumbersDivisibleByA(int a)
		{
			if (a > 1000)
			{
				int[] result = new int[0];
				return result;
			}
			else
			{
				int counter = 0;

				for (int i = a; i <= 1000; i += a)
				{
					counter++;
				}

				int[] result = new int[counter];
				int j = 0;

				for (int i = a; i <= 1000; i += a)
                {
					result[j] = i;
					j++;
                }
				return result;
			}
		}

		public static int FindNumberOfNumbersWithLessSquare(int a)
		{
			int number = 0;

			if (a > 0)
			{
				for (int i = 1; i * i < a; i++)
				{
					number++;
				}
			}
			return number;
		}

		public static int GetLargestDivisior(int a)
		{
			int divisor = 0;

			for (int i = 1; i < a; i++)
			{
				if (a % i == 0)
				{
					divisor = i;
				}
			}
			return divisor;
		}

		public static int GetSumOfNumbersDivisibleBySeven(int a, int b)
		{
			int tmp = 0;

			if (a > b)
			{
				tmp = a;
				a = b;
				b = tmp;
			}

			int sum = 0;

			for (int i = a; i <= b; i++)
			{
				if (i % 7 == 0)
				{
					sum += i;
				}
			}
			return sum;
		}

		public static int GetFibonacciSeriesNumber(int n)
		{
			if (n <= 0)
			{
				throw new Exception("n must be positive number");
			}

			int a = 1;
			int b = 1;
			int tmp = 0;

			for (int i = 3; i <= n; i++)
			{
				tmp = a;
				a = b;
				b = tmp + a;
			}
			return b;
		}

		public static int GetGreatestCommonDivisor(int a, int b)
		{
			if (a <= 0)
			{
				throw new Exception("a must be positive");
			}
			if (b <= 0)
			{
				throw new Exception("b must be positive");
			}

			while (a != b)
			{
				if (a > b)
				{
					a = a - b;
				}
				else
				{
					b = b - a;
				}
			}
			return a;
		}

		public static int GetNumberByHalfDivision(int a)
		{
			if (a <= 0)
			{
				throw new Exception("a must be positive");
			}

			int right = a;
			int left = 0;
			int n = 0;

			while (n * n * n != a)
			{
				n = (right + left) / 2;

				if (n * n * n < a)
				{
					left = n;
				}
				else
				{
					right = n;
				}
			}

			return n;
		}

		public static int GetNumberOfOddDigits(int a)
		{
			int x = a % 10;
			int number = 0;
			while (x != 0)
			{
				a = a / 10;
				if (x%2 == 1)
                {
					number++;
                }
				x = a % 10;
			}
            return number;
		}

		public static string WriteNumberBackwards(int a)
		{
			string result = "";
			while (a != 0)
			{
				int tmp = a % 10;
				result = result + Convert.ToString(tmp);
				a = a / 10;
			}
			return result;
		}

		public static void WriteNumbersWithMoreSumEvenDigits(int a)
		{
			if (a <= 0)
			{
				throw new Exception("a must be positive");
			}

			for (int i = 1; i <= a; i++)
			{
				int sumOdd = 0;
				int sumEven = 0;
				int j = i;
				while (j != 0)
				{
					int tmp = j % 10;
					if (tmp%2 == 1)
					{
						sumOdd += tmp;
					}
					else
					{
						sumEven += tmp;
					}
					j = j / 10;
				}
				if (sumEven > sumOdd)
				{
					Console.WriteLine(i);
				}
			}
		}

		public static string FindTheSameDigits(int a, int b)
		{
			if (a <= 0)
			{
				throw new Exception("a must be positive");
			}
			if (b <= 0)
			{
				throw new Exception("b must be positive");
			}

			bool result = false;

			while (a != 0)
			{
				int digitA = a % 10;
				while (b != 0)
				{
					int digitB = b % 10;
					if (digitA == digitB)
					{
						result = true;
						break;
					}
					b = b / 10;
				}
				a = a / 10;
			}
			string answer = "NO";
			if (result == true)
            {
				answer = "YES";
            }

			return answer;
		}
	}
}

