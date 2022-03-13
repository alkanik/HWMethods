using System;
namespace HWMethods
{
	public class ConditionalsController
	{
		public static int CalculateValue(int a, int b)
		{
			int result;
			if (a > b)
			{
				result = a + b;
			}
			else if (a == b)
			{
				result = a * b;
			}
			else
			{
				result = a - b;
			}
			return result;
		}

		public enum Quarters
        {
			I,
			II,
			III,
			IV,
			OneAxle
		}

		public static Quarters GetQuarter(double x, double y)
		{
			Quarters result;

			if (x > 0 && y > 0)
			{
				result = Quarters.I;
			}
			else if (x < 0 && y > 0)
			{
				result = Quarters.II;
			}
			else if (x < 0 && y < 0)
			{
				result = Quarters.III;
			}
			else if (x > 0 && y < 0)
			{
				result = Quarters.IV;
			}
			else
			{
				result = Quarters.OneAxle;
			}
			return result;
		}

		public static int[] SortAscendingOrder(int a, int b, int c)
		{
			int[] result = new int[3];

			if (a >= b && a >= c && b >= c)
			{
				result[0] = c;
				result[1] = b;
				result[2] = a;
			}
			else if (a >= b && a >= c && c >= b)
			{
				result[0] = b;
				result[1] = c;
				result[2] = a;
			}
			else if (b >= a && b >= c && a >= c)
			{
				result[0] = c;
				result[1] = a;
				result[2] = b;
			}
			else if (b >= a && b >= c && c >= a)
			{
				result[0] = a;
				result[1] = c;
				result[2] = b;
			}
			else if (c >= a && c >= b && a >= b)
			{
				result[0] = b;
				result[1] = a;
				result[2] = c;
			}
			else
			{
				result[0] = a;
				result[1] = b;
				result[2] = c;
			}

			return result;
		}

		public static double[] GetRootsOfQuadraticEquation(double a, double b, double c)
		{
			if (a == 0)
			{
				throw new Exception("a must be !=0");
			}

			double discriminant = b * b - 4 * a * c;
			double x1;

			if (discriminant == 0)
			{
				x1 = -b / 2 * a;
				double[] result = new double[1] { x1 };
				return result;
			}
			else if (discriminant > 0)
			{
				x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
				double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
				double[] result = new double[2] { x1, x2 };
				return result;
			}
			else
			{
				double[] result = new double[0];
				return result;
			}
			
		}

		public static string WriteNumberInWords(int a)
		{
			int a1 = a / 10;
			int a2 = a % 10;
			string part1 = "";
			string part2 = "";
			string result = "";

			if (a < 10 || a > 99)
			{
				throw new Exception("'a' must be integer positive two-digit number");
			}

			else if (a >= 10 && a < 20)
			{
				switch (a)
				{
					case 10:
						result = "Десять";
						break;
					case 11:
						result = "Одиннадцать";
						break;
					case 2:
						part1 = "Двадцать";
						break;
					case 12:
						result = "Двенадцать";
						break;
					case 13:
						result = "Тринадцать";
						break;
					case 14:
						result = "Четырнадцать";
						break;
					case 15:
						result = "Пятнадцать";
						break;
					case 16:
						result = "Шестьнадцать";
						break;
					case 17:
						result = "Семнадцать";
						break;
					case 18:
						result = "Весемнадцать";
						break;
					case 19:
						result = "Девятнадцать";
						break;
				}
			}
			else
			{
				switch (a1)
				{
					case 2:
						part1 = "Двадцать";
						break;
					case 3:
						part1 = "Тридцать";
						break;
					case 4:
						part1 = "Сорок";
						break;
					case 5:
						part1 = "Пятьдесят";
						break;
					case 6:
						part1 = "Шестьдесят";
						break;
					case 7:
						part1 = "Семьдесят";
						break;
					case 8:
						part1 = "Восемдесят";
						break;
					case 9:
						part1 = "Девяносто";
						break;
				}
                switch (a2)
				{
					case 0:
						part2 = "";
						break;
					case 1:
						part2 = " один";
						break;
					case 2:
						part2 = " два";
						break;
					case 3:
						part2 = " три";
						break;
					case 4:
						part2 = " четыре";
						break;
					case 5:
						part2 = " пять";
						break;
					case 6:
						part2 = " шесть";
						break;
					case 7:
						part2 = " семь";
						break;
					case 8:
						part2 = " восемь";
						break;
					case 9:
						part2 = " девять";
						break;
				}

				result = part1 + part2;
			}
			return result;
		}
	}
}