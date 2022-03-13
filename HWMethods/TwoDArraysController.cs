using System;
namespace HWMethods
{
	public static class TwoDArraysController
	{
		public static int GetMinimalElement(int[,] a)
        {
			if (a.Length==0)
            {
				throw new Exception("a can't be null");
            }

			int min = a[0,0];
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j=0; j<a.GetLength(1); j++)
                {
					if (a[i, j] < min)
					{
						min = a[i, j];
					}
				}
			}
			return min;
		}

		public static int GetMaximalElement(int[,] a)
		{

			if (a.Length == 0)
			{
				throw new Exception("a can't be null");
			}

			int max = a[0, 0];
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (a[i, j] > max)
					{
						max = a[i, j];
					}
				}
			}
			return max;
		}

		public static int[] GetMinimalElementsIndex(int[,] a)
		{

			if (a.Length == 0)
			{
				throw new Exception("a can't be null");
			}

			int min = a[0, 0];
			int[] minIndex = new int[2];
			for (int i = 0; i < a.GetLength(0); i++)
			{
				for (int j = 0; j < a.GetLength(1); j++)
				{
					if (a[i, j] < min)
					{
						min = a[i, j];
                        minIndex[0] = i;
						minIndex[1] = j;
					}
				}
			}
			return minIndex;
		}

		public static int[,] GenerateRandom(int lengthX, int lengthY)
		{
			Random r = new Random();
			int[,] a = new int[lengthX,lengthY];

			for (int i = 0; i < a.GetLength(0); i++)
			{
				for(int j=0; j<a.GetLength(1); j++)
                {
					a[i, j] = r.Next(-100, 101);
                }
			}
			return a;
		}

		public static void Print(int[,] a)
		{
			if (a.Length == 0)
				{
					throw new Exception("a can't be null");
				}

			for (int i = 0; i < a.GetLength(0); i++)
			{
				for(int j = 0; j < a.GetLength(1); j++)
                {
					int gap = 4 - a[i, j].ToString().Length;
					for (int k = 0; k < gap; k++)
                    {
						Console.Write(" ");
					}
					Console.Write($"{a[i, j]} ");
				}
				Console.WriteLine();
			}
		}
	}
}

