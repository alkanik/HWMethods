using System;
namespace HWMethods
{
	public class ArraysMethods
	{
		public static int[] GenerateArray(int lenght)
		{
			Random r = new Random();
			int[] a = new int[lenght];

			for (int i = 0; i < a.Length; i++)
			{
				a[i] = r.Next(-100,100);
			}
			return a;
		}

		public static void PrintAllArraysElements(int[] a)
		{
			for (int i = 0; i < a.Length; i++)
			{
				Console.Write(a[i] + " ");
			}
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
	}

	
}

