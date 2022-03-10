using System;
namespace HWMethods
{
	static class Variables
	{

		public static int GetResultOfDevision(int a, int b)
		{
			if (b==0)
			{
				throw new Exception("b must be !=0");
			}
			return a / b;
		}

		public static int GetRemainderOfDevision(int a, int b)
		{
			return a % b;
		}
		
		public static int GetResultOfExpression(int a, int b)
		{
			if (a == b)
			{
				throw new Exception("a must be !=b");
			}
			return (5 * a + b * b) / (b - a);
		}

		public static void SwapValues(ref string a, ref string b)
		{
			string tmp = b;
			b = a;
			a = tmp;
		}

		public static double SolveLinearEquation(double a, double b, double c)
		{
			if (a == 0)
			{
				throw new Exception("a must be !=0");
			}

			return (c - b) / a;
		}

		public static void WriteStraightLineEquation(double x1, double y1, double x2, double y2)
		{
			if (x1 == x2)
			{
				throw new Exception("x1 must be !=x2");
			}

			double a = (y1 - y2) / (x1 - x2);
			double b = y2 - a * x2;
			Console.WriteLine($"Y = {a}X + {b}");
		}

	}

}

