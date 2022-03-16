using NUnit.Framework;
using System;

namespace HWMethods.Test;


public class CyclesControllerTests
{
	[TestCase(2, 3, 8)]
	[TestCase(5, 0, 1)]
	[TestCase(0, 5, 0)]
	[TestCase(-7, 5, -16807)]
	public void ExponentiateTest(int a, int b, int expected)
	{
		int actual = CyclesController.Exponentiate(a, b);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(2,-2)]
	public void Exponentiate_WhenBLessZero_ThrowException(int a, int b)
	{
		Assert.Throws<Exception>(() => CyclesController.Exponentiate(a,b));
	}

	[TestCase(500, new int[] {500,1000})]
	[TestCase(1001, new int[] {})]
	public void GetNumbersDivisibleByATest(int a,int[] expected)
    {
		int[] actual = CyclesController.GetNumbersDivisibleByA(a);
		Assert.AreEqual(expected, actual);
    }

	[TestCase(-2)]
	public void GetNumbersDivisibleByA_WhenALessOrEqualZero_ThrowException(int a)
	{
		Assert.Throws<Exception>(() => CyclesController.GetNumbersDivisibleByA(a));
	}

	[TestCase(1000, 31)]
	[TestCase(1,0)]
	[TestCase(0, 0)]
	public void FindNumberOfNumbersWithLessSquareTest(int a, int expected)
	{
		int actual = CyclesController.FindNumberOfNumbersWithLessSquare(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2)]
	public void FindNumberOfNumbersWithLessSquare_WhenALessZero_ThrowException(int a)
	{
		Assert.Throws<Exception>(() => CyclesController.FindNumberOfNumbersWithLessSquare(a));
	}

	[TestCase(500, 250)]
	[TestCase(1, 0)]
	[TestCase(0, 0)]
	public void GetLargestDivisiorTest(int a, int expected)
	{
		int actual = CyclesController.GetLargestDivisior(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2)]
	public void GetLargestDivisior_WhenALessZero_ThrowException(int a)
	{
		Assert.Throws<Exception>(() => CyclesController.GetLargestDivisior(a));
	}

	[TestCase(-15, 10, -14)]
	[TestCase(1, 0, 0)]
	[TestCase(56, 3, 252)]
	public void GetSumOfNumbersDivisibleBySevenTest(int a, int b, int expected)
	{
		int actual = CyclesController.GetSumOfNumbersDivisibleBySeven(a,b);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(5, 5)]
	[TestCase(1, 1)]
	[TestCase(23, 28657)]
	public void GetFibonacciSeriesNumberTest(int n, int expected)
	{
		int actual = CyclesController.GetFibonacciSeriesNumber(n);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2)]
	[TestCase(0)]
	public void GetFibonacciSeriesNumber_WhenNLessOrEqualZero_ThrowException(int n)
	{
		Assert.Throws<Exception>(() => CyclesController.GetFibonacciSeriesNumber(n));
	}

	[TestCase(23, 3, 1)]
	[TestCase(125, 50, 25)]
	[TestCase(1, 1, 1)]
	public void GetGreatestCommonDivisorTest(int a, int b, int expected)
	{
		int actual = CyclesController.GetGreatestCommonDivisor(a,b);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2, 5)]
	[TestCase(7,0)]
	public void GetGreatestCommonDivisor_WhenAOrBLessOrEqualZero_ThrowException(int a, int b)
	{
		Assert.Throws<Exception>(() => CyclesController.GetGreatestCommonDivisor(a,b));
	}

	[TestCase(8, 2)]
	[TestCase(125, 5)]
	[TestCase(343, 7)]
	public void GetNumberByHalfDivisionTest(int a, int expected)
	{
		int actual = CyclesController.GetNumberByHalfDivision(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(0)]
	[TestCase(-2)]
	public void GetNumberByHalfDivision_WhenALessOrEqualZero_ThrowException(int a)
	{
		Assert.Throws<Exception>(() => CyclesController.GetNumberByHalfDivision(a));
	}

	[TestCase(15, 2)]
	[TestCase(66, 0)]
	[TestCase(0,0)]
	public void GetNumberOfOddDigitsTest(int a, int expected)
	{
		int actual = CyclesController.GetNumberOfOddDigits(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2)]
	public void GetNumberOfOddDigits_WhenALessOrEqualZero_ThrowException(int a)
	{
		Assert.Throws<Exception>(() => CyclesController.GetNumberOfOddDigits(a));
	}

	[TestCase(1, 1)]
	[TestCase(1000, 1)]
	[TestCase(123, 321)]
	public void GetNumberBackwardsTest(int a, int expected)
	{
		int actual = CyclesController.GetNumberBackwards(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2)]
	[TestCase(0)]
	public void GetNumberBackwards_WhenALessOrEqualZero_ThrowException(int a)
	{
		Assert.Throws<Exception>(() => CyclesController.GetNumberBackwards(a));
	}

	[TestCase(7, new int[] {2,4,6})]
	[TestCase(20, new int[] { 2, 4, 6,8,12,14,16,18,20 })]
	public void GetNumbersWithMoreSumEvenDigitsTest(int n, int [] expected)
	{
		int[] actual = CyclesController.GetNumbersWithMoreSumEvenDigits(n);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(-2)]
	[TestCase(0)]
	public void GetNumbersWithMoreSumEvenDigits_WhenALessOrEqualZero_ThrowException(int n)
	{
		Assert.Throws<Exception>(() => CyclesController.GetNumbersWithMoreSumEvenDigits(n));
	}

	[TestCase(-7, 777, "YES")]
	[TestCase(50, 65909, "YES")]
	[TestCase(-11, 22, "NO")]
	[TestCase(0, 10, "YES")]
	[TestCase(210, 0, "YES")]
	public void FindTheSameDigitsTest(int a, int b, string expected)
	{
		string actual = CyclesController.FindTheSameDigits(a,b);
		Assert.AreEqual(expected, actual);
	}

}



