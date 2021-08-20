using Xunit;
using Packt;
using System;

namespace CalculatorLibUnitTest;

public class CalculatorLibUnitTests
{
    [Fact]
    public void TestAdding2And2()
    {
        // arrange
        double a = 2;
        double b = 2;
        double expected = 4;
        var calc = new Calculator();

        // act
        double actual = calc.Add(a, b);

        // assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void TestAdding2And3()
    {
    //Given
        double a = 2;
        double b = 3;
        double expected = 5;
        var calc = new Calculator();
    //When
        double actual = calc.Add(a, b);
    //Then
        Assert.Equal(expected, actual);
    }
}