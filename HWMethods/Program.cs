using HWMethods;

// Пользователь вводит 1 число. Найти количество нечетных цифр этого числа.

Console.WriteLine("Введите целое положительное число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Cycles.GetNumberOfOddDigits(a));