using NUnit.Framework;
using System;

namespace HWMethods.Test;

public class VariablesControllerTests
{
    [TestCase(10, 2, 5)]
    [TestCase(7, 3, 2)]
    [TestCase(4, 9, 0)]
    [TestCase(0, 2, 0)]
    [TestCase(-8, -4, 2)]
    public void GetResultOfDivisionTest(int a, int b, int expected)
    {
        int actual = VariablesController.GetResultOfDivision(a, b);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(10, 0)]
    [TestCase(0, 0)]
    [TestCase(-10, 0)]
    public void GetResultOfDivisionTest_WhenBEqualZero_ShoulldThrowException(int a, int b)
    {
        Assert.Throws<Exception>(() => VariablesController.GetResultOfDivision(a, b));
    }

    [TestCase(10, 2, 0)]
    [TestCase(4, 9, 4)]
    [TestCase(0, 2, 0)]
    [TestCase(-8, -4, 0)]
    [TestCase(-9, -4, -1)]
    public void GetRemainderOfDivisionTest(int a, int b, int expected)
    {
        int actual = VariablesController.GetRemainderOfDivision(a, b);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(10, 0)]
    [TestCase(0, 0)]
    [TestCase(-10, 0)]
    public void GetRemainderOfDivision_WhenBEqualZero_ShoulldThrowException(int a, int b)
    {
        Assert.Throws<Exception>(() => VariablesController.GetRemainderOfDivision(a, b));
    }

    [TestCase(5, 6, 61)]
    [TestCase(-10, -2, -5)]
    [TestCase(0, 5, 5)]
    [TestCase(4, 0, -5)]
    public void GetResultOfExpressionTest(int a, int b, int expected)
    {
        int actual = VariablesController.GetResultOfExpression(a, b);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(0, 0)]
    [TestCase(5, 5)]
    [TestCase(-10, -10)]
    public void GetResultOfExpression_WhenAEqualB_ShoulldThrowException(int a, int b)
    {
        Assert.Throws<Exception>(() => VariablesController.GetResultOfExpression(a, b));
    }

    [TestCase("qwe", "rty", "rty", "qwe")]
    [TestCase("123", "456", "456", "123")]
    public void SwapValuesTest(ref string a, ref string b, string expectedA, string expectedB)
    {
        VariablesController.SwapValues(ref a, ref b);
        Assert.AreEqual(expectedA, a);
        Assert.AreEqual(expectedB, b);
    }

    [TestCase(2, 6, 10, 2)]
    [TestCase(-5, 0, 800, -160)]
    [TestCase(1, 1, 1, 0)]
    public void SolveLinearEquationTest(double a, double b, double c, double expected)
    {
        double actual = VariablesController.SolveLinearEquation(a, b, c);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(0, 1, 2)]
    public void SolveLinearEquation_WhenAEqualZero_ShouldThrowException(double a, double b, double c)
    {
        Assert.Throws<Exception>(() => VariablesController.SolveLinearEquation(a, b, c));
    }

    [TestCase(1,2,3,4,"Y = 1X + 1")]
    [TestCase(8, -1, -2, 10, "Y = -1.1X + 7.8")]
    public void WriteStraightLineEquationTest(double x1, double y1, double x2, double y2, string expected)
    {
        string actual = VariablesController.WriteStraightLineEquation(x1,y1,x2,y2);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(1,2,1,3)]
    public void WriteStraightLineEquation_WhenX1EqualX2_ShouldThrowException(double x1, double y1, double x2, double y2)
    {
        Assert.Throws<Exception>(() => VariablesController.WriteStraightLineEquation(x1, y1, x2,y2));
    }


}
