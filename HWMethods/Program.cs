using HWMethods;

// Пользователь вводит целое положительное число, которое является кубом целого числа N.
// Найдите число N методом половинного деления.

Console.WriteLine("Введите целое положительное число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Cycles.GetNumberByHalfDivision(a));