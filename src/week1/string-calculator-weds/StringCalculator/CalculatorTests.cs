

namespace StringCalculator;
public class CalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new Calculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }


    [Theory]
    [InlineData("1", 1)]

    public void SingleDigit(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("2,3", 5)]

    public void TwoDigits(string numbers, int expected)
    {
        var calculator = new Calculator();

        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);
    }


    [Theory]
    [InlineData("3,5,6,7,8", 29)]

    public void AnyLength(string numbers, int expected)
    {
        var calculator = new Calculator();
        var result = calculator.Add(numbers);

        Assert.Equal(expected, result);

    }
}
