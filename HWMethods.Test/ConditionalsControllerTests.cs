using NUnit.Framework;
using System;

namespace HWMethods.Test;

public class ConditionalsControllerTests
{

	[TestCase(1, 2, -1)]
	[TestCase(2, 2, 4)]
	[TestCase(3, 2, 5)]
	public void CalculateValueTest(int a, int b, int expected)
	{
		int actual = ConditionalsController.CalculateValue(a, b);
		Assert.AreEqual(expected, actual);
	}

	//[TestCase(1, 1, Quarters.I)]
	//[TestCase(1, -1, Quarters.II)]
	//[TestCase(-2, 3, Quarters.III)]
	//[TestCase(-5, -1, Quarters.IV)]
	//[TestCase(0, 1, Quarters.OnAxle)]
	//public void GetQuarterTest(double x, double y, Quarters expected)
	//{
	//	Quarter actual = ConditionalsController.GetQuarter(x,y);
	//	Assert.AreEqual(expected, actual);
	//}

	[TestCase(1, 2, 3, new int[] {1,2,3})]
    [TestCase(2, 1, 3, new int[] { 1, 2, 3 })]
	[TestCase(3, 2, 1, new int[] { 1, 2, 3 })]
	[TestCase(1, 1, 1, new int[] { 1, 1, 1 })]
	[TestCase(0, 16, 3, new int[] { 0, 3, 16 })]
	[TestCase(-1, -2, -3, new int[] { -3, -2, -1 })]
	public void SortAscendingOrderTest(int a, int b, int c, int[] expected)
	{
		int[] actual = ConditionalsController.SortAscendingOrder(a, b,c);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(1, 2, 1, new double[] { -1 })]
	[TestCase(1, 4, 1, new double[] { -0.2679491924311228, -3.732050807568877 })]
	[TestCase(1, 1, 1, new double[] { })]
	public void GetRootsOfQuadraticEquationTest(double a, double b, double c, double[] expected)
    {
		double[] actual = ConditionalsController.GetRootsOfQuadraticEquation(a, b, c);
		Assert.AreEqual(expected, actual);

	}

	[TestCase(0,1,1)]
	public void GetRootsOfQuadraticEquation_WhenAEqualZero_ThrowException(double a, double b, double c)
	{
		Assert.Throws<Exception>(() => ConditionalsController.GetRootsOfQuadraticEquation(a, b,c));
	}

	[TestCase(22, "Двадцать два")]
	[TestCase(11, "Одиннадцать")]
	[TestCase(90, "Девяносто")]
	public void WriteNumberInWordsTest(int a, string expected)
	{
		string actual = ConditionalsController.WriteNumberInWords(a);
		Assert.AreEqual(expected, actual);

	}

	[TestCase(100)]
	[TestCase(-100)]
	[TestCase(9)]
	public void WriteNumberInWords_WhenALessTenOrMoreNinetyNine (int a)
	{
		Assert.Throws<Exception>(() => ConditionalsController.WriteNumberInWords(a));
	}

}
	


