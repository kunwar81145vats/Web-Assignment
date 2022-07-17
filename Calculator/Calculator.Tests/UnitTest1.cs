using Microsoft.VisualStudio.TestTools.UnitTesting;
using Calculator.Library;

namespace Calculator.Tests;

[TestClass]
public class UnitTest1
{
    [TestMethod]
    public void TestMethod1()
    {
    }

    [DataTestMethod]
    [DataRow(1, 1, 2)]
    [DataRow(2, 2, 4)]
    [DataRow(0, 2, 2)]
    [DataRow(2, 7, 9)]
    [DataRow(10, 3, 13)]
    [DataRow(7, 15, 22)]
    public void CalculatorAddMethodMustAdd(double left, double right, double expected)
    {
        double result;
        result = Calculator.Calculate(left, right, +);
        Assert.AreEqual(expected, result);
    }
}
