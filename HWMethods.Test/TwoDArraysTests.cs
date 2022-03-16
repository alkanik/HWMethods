using NUnit.Framework;
using System;

namespace HWMethods.Test;

public class TwoDArraysControllerTests
{

    [TestCase(TwoDArraysMockType.one, 1)]
    [TestCase(TwoDArraysMockType.two, 0)]
    [TestCase(TwoDArraysMockType.three, -10)]
    public void GetMinimalElementTest(TwoDArraysMockType type, int expected)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int actual = TwoDArraysController.GetMinimalElement(a);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(TwoDArraysMockType.empty)]
    public void GetMinimalElement_WhenArrayIsEmpty_ThrowException(TwoDArraysMockType type)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        Assert.Throws<Exception>(() => TwoDArraysController.GetMinimalElement(a));
    }

    [TestCase(TwoDArraysMockType.one, 5)]
    [TestCase(TwoDArraysMockType.two, 6)]
    [TestCase(TwoDArraysMockType.three, 654)]
    public void GetMaximalElementTest(TwoDArraysMockType type, int expected)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int actual = TwoDArraysController.GetMaximalElement(a);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(TwoDArraysMockType.empty)]
    public void GetMaximalElement_WhenArrayIsEmpty_ThrowException(TwoDArraysMockType type)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        Assert.Throws<Exception>(() => TwoDArraysController.GetMaximalElement(a));
    }

    [TestCase(TwoDArraysMockType.one, new int[] {0,0})]
    [TestCase(TwoDArraysMockType.two, new int[] { 0, 0 })]
    [TestCase(TwoDArraysMockType.three, new int[] { 0, 3 })]
    public void GetMinimalElementsIndexTest(TwoDArraysMockType type, int[] expected)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int[] actual = TwoDArraysController.GetMinimalElementsIndex(a);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(TwoDArraysMockType.empty)]
    public void GetMinimalElementsIndex_WhenArrayIsEmpty_ThrowException(TwoDArraysMockType type)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        Assert.Throws<Exception>(() => TwoDArraysController.GetMinimalElementsIndex(a));
    }

    [TestCase(TwoDArraysMockType.one, new int[] { 2,2 })]
    [TestCase(TwoDArraysMockType.two, new int[] { 3,3 })]
    [TestCase(TwoDArraysMockType.three, new int[] { 3,1 })]
    public void GetMaximalElementsIndexTest(TwoDArraysMockType type, int[] expected)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int[] actual = TwoDArraysController.GetMaximalElementsIndex(a);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(TwoDArraysMockType.empty)]
    public void GetMaximalElementsIndex_WhenArrayIsEmpty_ThrowException(TwoDArraysMockType type)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        Assert.Throws<Exception>(() => TwoDArraysController.GetMaximalElementsIndex(a));
    }

    [TestCase(TwoDArraysMockType.one, 1)]
    [TestCase(TwoDArraysMockType.three, 7)]
    [TestCase(TwoDArraysMockType.empty, 0)]
    public void GetCountElementsLargerThanNeighborsTest(TwoDArraysMockType type, int expected)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int actual = TwoDArraysController.GetCountElementsLargerThanNeighbors(a);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(TwoDArraysMockType.one, TwoDArraysMockType.oneFlip)]
    [TestCase(TwoDArraysMockType.three, TwoDArraysMockType.threeFlip)]
    [TestCase(TwoDArraysMockType.empty, TwoDArraysMockType.empty)]
    public void FlipMainDiagonalyTest(TwoDArraysMockType type, TwoDArraysMockType expectedType)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int[,] expected = TwoDArraysMock.GetMock(expectedType);
        int[,] actual = TwoDArraysController.FlipMainDiagonal(a);
        Assert.AreEqual(expected, actual);
    }

    [TestCase(TwoDArraysMockType.notSquare)]
    public void FlipMainDiagonal_WhenArrayIsNotSquare_ThrowException(TwoDArraysMockType type)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        Assert.Throws<Exception>(() => TwoDArraysController.FlipMainDiagonal(a));
    }

    [TestCase(TwoDArraysMockType.one, TwoDArraysMockType.one)]
    [TestCase(TwoDArraysMockType.two, TwoDArraysMockType.two)]
    [TestCase(TwoDArraysMockType.empty, TwoDArraysMockType.empty)]
    public void CopyTest(TwoDArraysMockType type, TwoDArraysMockType expectedType)
    {
        int[,] a = TwoDArraysMock.GetMock(type);
        int[,] expected = TwoDArraysMock.GetMock(expectedType);
        int[,] actual = TwoDArraysController.Copy(a);
        Assert.AreEqual(expected, actual);
    }
}

