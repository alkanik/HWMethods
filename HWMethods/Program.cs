using HWMethods;

int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());

//int[] a = ArraysMethods.GenerateArray(n);

//ArraysMethods.PrintArray(a);

//ArraysMethods.PrintArray(ArraysMethods.SwapHalves(a));
Console.WriteLine(Cycles.FindTheSameDigits(a, b));