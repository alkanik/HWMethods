using NUnit.Framework;
using System;

namespace HWMethods.Test;

public class ConditionalsControllerTests
{

	[TestCase(1,2,-1)]
	[TestCase(2, 2, 4)]
	[TestCase(3, 2, 5)]
	public void CalculateValueTest(int a, int b, int expected)
	{
		int actual = ConditionalsController.CalculateValue(a, b);
		Assert.AreEqual(expected, actual);
	}

	[TestCase(1, 1, Quarter.I)]
	[TestCase(1, -1, Quarter.II)]
	[TestCase(-2, 3, Quarter.III)]
	[TestCase(-5, -1, Quarter.IV)]
	[TestCase(0, 1, Quarter.OnAxle)]
	public void GetQuarterTest(double x, double y, Quarter expected)
	{
		Quarter actual = ConditionalsController.GetQuarter(x,y);
		Assert.AreEqual(expected, actual);
	}
}
	


