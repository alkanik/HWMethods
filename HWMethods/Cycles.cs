﻿using System;
namespace HWMethods
{
	public class Cycles
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

		public static int FindNumberOfNumbersWithLessSquare(int a)
		{
			int number = 0;

			for (int i = 1; i * i < a; i++)
			{
				number++;
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
	}
}
