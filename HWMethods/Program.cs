using HWMethods;

// Пользователь вводит целое положительное  число (N).
// Выведите числа в диапазоне от 1 до N, сумма четных цифр которых больше суммы нечетных. 


Console.WriteLine("Введите целое положительное число:");
int a = Convert.ToInt32(Console.ReadLine());

Cycles.WriteNumbersWithMoreSumEvenDigits(a);