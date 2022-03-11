using HWMethods;

int n = Convert.ToInt32(Console.ReadLine());

int[] a = ArraysMethods.GenerateArray(n);

ArraysMethods.PrintArray(a);

ArraysMethods.PrintArray(ArraysMethods.SortSelectDescending(a));