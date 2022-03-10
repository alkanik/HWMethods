using System;
namespace HWMethods
{
	public class ArraysMethods
	{
		public static int[] GenerateArray(int length)
		{
			Random r = new Random();
			int[] a = new int[length];

			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(-100,101);
			}
			return a;
		}
		
		public static void PrintArray(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
			Console.WriteLine();
		}

		public static int[] CopyArray(int[] a)
		{
			int[] newArray = new int[a.Length];
			Array.Copy(a, newArray, a.Length);
			return newArray;
		}
		

		public static int FindMinimalArraysElement(int[] a)
		{
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

		public static int FindMaximalArraysElement(int[] a)
		{
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
		public static int FindIndexOfMinimalArraysElement(int[] a)
		{
			int min = a[0];
			int indexOfMinimalElement = 0;
			for (int i = 1; i < a.Length; i++)
			{
				if (a[i] > min)
				{
					min = a[i];
					indexOfMinimalElement = i;
				}
			}
			
			return indexOfMinimalElement;
		}
		public static int FindIndexOfMaximalArraysElement(int[] a)
		{
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

		public static int GetSumOfOddArraysElements(int[] a)
		{
			int sumOfOddElements = 0;
			
			for (int i = 1; i < a.Length; i+=2)
			{
				sumOfOddElements += a[i];
			}

			return sumOfOddElements;
		}

		public static int[] ReverseArray(int[] a)
		{
			int[] result = CopyArray(a);
			for (int i = 0; i < (result.Length / 2); i++)
			{
				int tmp = result[i];
				result[i] = result[result.Length - (1 + i)];
				result[result.Length - (1 + i)] = tmp;
			}
			return result;
		}
	}

	
}

