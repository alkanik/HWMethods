using HWMethods;

int n = Convert.ToInt32(Console.ReadLine());

int[] a = ArraysMethods.GenerateArray(n);

//ArraysMethods.PrintAllArraysElements(a);

Console.WriteLine(ArraysMethods.FindMaximalArraysElement(a));