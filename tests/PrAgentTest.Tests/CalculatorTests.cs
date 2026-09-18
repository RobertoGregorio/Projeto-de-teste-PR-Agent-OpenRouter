using PrAgentTest;

namespace PrAgentTest.Tests;

public sealed class CalculatorTests
{
    [Fact]
    public void Add_ReturnsSum()
    {
        var calculator = new Calculator();

        var result = calculator.Add(2, 3);

        Assert.Equal(5, result);
    }

    [Fact]
    public void Divide_ReturnsQuotient()
    {
        var calculator = new Calculator();

        var result = calculator.Divide(10, 2);

        Assert.Equal(5, result);
    }
}
