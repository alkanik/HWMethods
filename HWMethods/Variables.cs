using System;
namespace HWMethods
{
	static class Variables
	{

		public static int GetResultOfDevision(int a, int b)
		{
			return a / b;
		}

		public static int GetRemainderOfDevision(int a, int b)
		{
			return a % b;
		}
		
		public static int GetResultOfExpression(int a, int b)
		{
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
			return (c - b) / a;
		}

		public static void WriteStraightLineEquation(double x1, double y1, double x2, double y2)
		{
			double a = (y1 - y2) / (x1 - x2);
			double b = y2 - a * x2;
			Console.WriteLine($"Y = {a}X + {b}");
		}

	}

}

