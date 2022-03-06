using System;
namespace HWMethods
{
	public class Branches
	{
		public static void CalculateTheValue(int a, int b)
		{
			if (a > b)
			{
				Console.WriteLine("A + B = " + (a + b));
			}
			else if (a == b)
			{
				Console.WriteLine("A * B = " + (a * b));
			}
			else
			{
				Console.WriteLine("A - B = " + (a - b));
			}
		}

		public static void WriteQuarter(double x, double y)
		{
			if (x > 0 && y > 0)
			{
				Console.WriteLine("Точка принадлежит 1 четверти");
			}
			else if (x < 0 && y > 0)
			{
				Console.WriteLine("Точка принадлежит 2 четверти");
			}
			else if (x < 0 && y < 0)
			{
				Console.WriteLine("Точка принадлежит 3 четверти");
			}
			else if (x > 0 && y < 0)
			{
				Console.WriteLine("Точка принадлежит 4 четверти");
			}
			else
			{
				Console.WriteLine("Точка лежит на оси координат");
			}
		}

		public static void WriteNumbersInAscendingOrder(int a, int b, int c)
		{
			if (a >= b && a >= c && b >= c)
			{
				Console.WriteLine($"{c} {b} {a}");
			}
			else if (a >= b && a >= c && c >= b)
			{
				Console.WriteLine($"{b} {c} {a}");
			}
			else if (b >= a && b >= c && a >= c)
			{
				Console.WriteLine($"{c} {a} {b}");
			}
			else if (b >= a && b >= c && c >= a)
			{
				Console.WriteLine($"{a} {c} {b}");
			}
			else if (c >= a && c >= b && a >= b)
			{
				Console.WriteLine($"{b} {a} {c}");
			}
			else
			{
				Console.WriteLine($"{a} {b} {c}");
			}
		}

		public static void WriteSolutionOfQuadraticEquation(double a, double b, double c)
		{
			double discriminant = b * b - 4 * a * c;
			double x1;

			if (discriminant == 0)
			{
				x1 = -b / 2 * a;
				Console.WriteLine($"x = {x1}");
			}
			else if (discriminant > 0)
			{
				x1 = (-b + Math.Sqrt(discriminant)) / 2 * a;
				double x2 = (-b - Math.Sqrt(discriminant)) / 2 * a;
				Console.WriteLine($"x1 = {x1}, x2 = {x2}");
			}
			else
			{
				Console.WriteLine("Действительных корней нет.");
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