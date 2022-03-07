using HWMethods;

// Пользователь вводит 1 число.
// Найти число, которое является зеркальным отображением последовательности цифр заданного числа,
// например, задано число 123, вывести 321.


Console.WriteLine("Введите целое положительное число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Cycles.WriteNumberBackwards(a));