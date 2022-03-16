using NUnit.Framework;
using System;

namespace HWMethods.Test;

public class ArraysControllerTests
{

	[TestCase(new int[] { 1, 2, 3 }, 1)]
	[TestCase(new int[] { -1, 100, 2 }, -1)]
	public void FindMinimalElementTest(int[] a, int expected)
	{
		int actual = ArraysController.FindMinimalElement(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { })]
	public void FindMinimalElement_WhenArrayIsEmpty_ThrowException(int[] a)
	{
		Assert.Throws<Exception>(() => ArraysController.FindMinimalElement(a));
	}


	[TestCase(new int[] { 1, 2, 3 }, 3)]
	[TestCase(new int[] { -1, 100, 2 }, 100)]
	public void FindMaximalElementTest(int[] a, int expected)
	{
		int actual = ArraysController.FindMaximalElement(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { })]
	public void FindMaximalElement_WhenArrayIsEmpty_ThrowException(int[] a)
	{
		Assert.Throws<Exception>(() => ArraysController.FindMaximalElement(a));
	}

	[TestCase(new int[] { 1, 2, 3 }, 0)]
	[TestCase(new int[] { -1, 100, 2 }, 0)]
	[TestCase(new int[] { -1, 100, -20 }, 2)]
	public void FindIndexOfMinimalElementTest(int[] a, int expected)
	{
		int actual = ArraysController.FindIndexOfMinimalElement(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { })]
	public void FindIndexOfMinimalElement_WhenArrayIsEmpty_ThrowException(int[] a)
	{
		Assert.Throws<Exception>(() => ArraysController.FindIndexOfMinimalElement(a));
	}

	[TestCase(new int[] { 1, 2, 3 }, 2)]
	[TestCase(new int[] { -1, 100, 2 }, 1)]
	[TestCase(new int[] { 1, -100, -20 }, 0)]
	public void FindIndexOfMaximalElementElementTest(int[] a, int expected)
	{
		int actual = ArraysController.FindIndexOfMaximalElement(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { })]
	public void FindIndexOfMaximalElement_WhenArrayIsEmpty_ThrowException(int[] a)
	{
		Assert.Throws<Exception>(() => ArraysController.FindIndexOfMaximalElement(a));
	}

	[TestCase(new int[] { 1, 2, 3 }, 2)]
	[TestCase(new int[] { -1, 100, 2, 1 }, 101)]
	[TestCase(new int[] { }, 0)]
	public void GetSumOfOddElementsTest(int[] a, int expected)
	{
		int actual = ArraysController.GetSumOfOddElements(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { 1, 2, 3 }, new int[] { 3,2,1 })]
	[TestCase(new int[] { -1, 100, 2, 1 }, new int[] { 1, 2, 100, -1 })]
	[TestCase(new int[] { }, new int[] { })]
	public void ReverseTest(int[] a, int[] expected)
	{
		int[] actual = ArraysController.Reverse(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { 1, 2, 3 }, 1)]
	[TestCase(new int[] { -1, 100, 2, 1 }, 2)]
	[TestCase(new int[] { }, 0)]
	public void GetNumberOfOddElementsTest(int[] a, int expected)
	{
		int actual = ArraysController.GetNumberOfOddElements(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
	[TestCase(new int[] { -1, 100, 2, 1 }, new int[] { 2, 1, -1, 100 })]
	[TestCase(new int[] { 1}, new int[] { 1})]
	[TestCase(new int[] { }, new int[] { })]
	public void SwapHalvesTest(int[] a, int[] expected)
	{
		int[] actual = ArraysController.SwapHalves(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
	[TestCase(new int[] { -1, 100, 2, 1 }, new int[] { -1, 1, 2, 100 })]
	[TestCase(new int[] { 1 }, new int[] { 1 })]
	[TestCase(new int[] { }, new int[] { })]
	public void SortAscendingTest(int[] a, int[] expected)
	{
		int[] actual = ArraysController.SortAscending(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { 1, 2, 3 }, new int[] { 3, 2, 1 })]
	[TestCase(new int[] { -1, 100, 2, 1 }, new int[] { 100, 2, 1, -1 })]
	[TestCase(new int[] { 1 }, new int[] { 1 })]
	[TestCase(new int[] { }, new int[] { })]
	public void SortDescendingTest(int[] a, int[] expected)
	{
		int[] actual = ArraysController.SortDescending(a);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(new int[] { 1, 2, 3 }, new int[] { 1, 2, 3 })]
	[TestCase(new int[] { 1, -1, 2 }, new int[] { 1, -1, 2 })]
	[TestCase(new int[] { }, new int[] { })]
	public void CopyTest(int[] a, int[] expected)
	{
		int[] actual = ArraysController.Copy(a);
		Assert.AreEqual(expected, actual);
	}
}

