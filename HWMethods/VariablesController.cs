using System;
namespace HWMethods
{
	public static class VariablesController
	{

		public static int GetResultOfDivision(int a, int b)
		{
			if (b==0)
			{
				throw new Exception("b must be !=0");
			}
			return a / b;
		}

		public static int GetRemainderOfDivision(int a, int b)
		{
			if (b == 0)
			{
				throw new Exception("b must be !=0");
			}
			return a % b;
		}
		
		public static int GetResultOfExpression(int a, int b)
		{
			if (a == b)
			{
				throw new Exception("a can't be equal b");
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
				throw new Exception("a can't be equal 0");
			}

			double result = (c - b) / a;
			return result;
		}

		public static string WriteStraightLineEquation(double x1, double y1, double x2, double y2)
		{
			if (x1 == x2)
			{
				throw new Exception("x1 must be !=x2");
			}

			double a = (y1 - y2) / (x1 - x2);
			double b = y2 - a * x2;
			string result = $"Y = {a}X + {b}";
			return result;
		}

	}

}

