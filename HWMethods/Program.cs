using HWMethods;

// Пользователь вводит 4 числа (X1, Y1, X2, Y2), описывающие координаты 2-х точек на координатной плоскости.
// Выведите уравнение прямой в формате Y=AX+B, проходящей через эти точки.

Console.WriteLine("Введите координату X1:");
double x1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y1:");
double y1 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату X2:");
double x2 = Convert.ToDouble(Console.ReadLine());
Console.WriteLine("Введите координату Y2:");
double y2 = Convert.ToDouble(Console.ReadLine());

Variables.WriteStraightLineEquation(x1, y1, x2, y2);