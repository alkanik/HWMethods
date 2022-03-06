using HWMethods;

Console.WriteLine("Введите целое двузначное число:");
int a = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(Branches.WriteNumberInWords(a));