using System;
namespace HWMethods
{
	public class ArraysController
	{

		public static int FindMinimalElement(int[] a)
		{
			if (a.Length==0)
            {
				throw new Exception("a can't be empty");
            }

			int min = a[0];
			for (int i = 1; i< a.Length; i++)
			{
				if (a[i] < min)
				{
					min = a[i];
				}
			}
			return min;
		}

		public static int FindMaximalElement(int[] a)
		{
			if (a.Length == 0)
			{
				throw new Exception("a can't be empty");
			}

			int max = a[0];
			for (int i = 1; i < a.Length; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
				}
			}
			return max;
		}
		public static int FindIndexOfMinimalElement(int[] a)
		{
			if (a.Length == 0)
			{
				throw new Exception("a can't be empty");
			}

			int min = a[0];
			int indexOfMinimalElement = 0;
			for (int i = 1; i < a.Length; i++)
			{
				if (a[i] < min)
				{
					min = a[i];
					indexOfMinimalElement = i;
				}
			}
			
			return indexOfMinimalElement;
		}
		public static int FindIndexOfMaximalElement(int[] a)
		{
			if (a.Length == 0)
			{
				throw new Exception("a can't be empty");
			}

			int max = a[0];
			int indexOfMaximalElement = 0;
			for (int i = 1; i < a.Length; i++)
			{
				if (a[i] > max)
				{
					max = a[i];
					indexOfMaximalElement = i;
				}
			}

			return indexOfMaximalElement;
		}

		public static int GetSumOfOddElements(int[] a)
		{
			int sumOfOddElements = 0;

			if (a.Length > 1)
            {
				for (int i = 1; i < a.Length; i += 2)
				{
					sumOfOddElements += a[i];
				}
			}

			return sumOfOddElements;
		}

		public static int[] Reverse(int[] a)
		{
			int[] result = Copy(a);
			for (int i = 0; i < (result.Length / 2); i++)
			{
				int tmp = result[i];
				result[i] = result[result.Length - (1 + i)];
				result[result.Length - (1 + i)] = tmp;
			}
			return result;
		}

		public static int GetNumberOfOddElements(int[] a)
		{
			int numberOfOddElements = 0;

			for (int i = 1; i <= a.Length; i += 2)
			{
				numberOfOddElements += 1;
			}
			return numberOfOddElements;
		}

		public static int[] SwapHalves(int[] a)
		{
			int[] result = Copy(a);

			if (a.Length % 2 == 0)
			{
				for (int i = 0; i < (a.Length / 2); i++)
				{
					int tmp = result[i];
					result[i] = result[(result.Length / 2) + i];
					result[(result.Length / 2) + i] = tmp;
				}
			}
			else
			{
				for (int i = 0; i < (a.Length / 2); i++)
				{
					int tmp = result[i];
					result[i] = result[(result.Length / 2) + 1+ i];
					result[(result.Length / 2) + 1+i] = tmp;
				}
			}
			return result;
		}

		public static int[] SortAscending(int[] a)
        {
			int[] result = Copy(a);
			int tmp = 0;
			for (int i = 0; i < result.Length - 1; i++)
			{
				for (int j = i + 1; j < result.Length; j++)
				{
					if (result[i] > result[j])
					{
						tmp = result[i];
						result[i] = result[j];
						result[j] = tmp;
					}
				}
			}
			return result;
        }

		public static int[] SortDescending(int[] a)
        {
			int[] result = Copy(a);
			for (int i = result.Length - 1; i >= 0; i--)
			{
				int max = i;
				for (int j = i - 1; j >= 0; j--)
				{
					if (result[j] < result[max])
					{
						max = j;
					}
				}

				int tmp = result[i];
				result[i] = result[max];
				result[max] = tmp;
			}

			return result;
		}

		public static int[] GenerateArray(int length)
		{
			Random r = new Random();
			int[] a = new int[length];

			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(-100, 101);
			}
			return a;
		}

		public static void PrintIntArray(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write($"{a[i]} ");
			}
			Console.WriteLine();
		}

		public static void PrintDoubleArray(double[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
			Console.WriteLine();
		}

		public static int[] Copy(int[] a)
		{
			int[] newArray = new int[a.Length];
			Array.Copy(a, newArray, a.Length);
			return newArray;
		}
	}
}