

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
  [InlineData("3", 3)]
  public void SingleDigit(string number, int expected)
  {
    var calculator = new Calculator();

    var result = calculator.Add(number);

    Assert.Equal(result.ToString(), number);
  }


  [Theory]
  [InlineData("3,2", 5)]
  public void TwoDigits(string number, int expected)
  {
    var calculator = new Calculator();

    var result = calculator.Add(number);

    Assert.Equal(result, expected);
  }

  [Theory]
  [InlineData("2,3,4,5,6", 20)]
  public void AnyLength(string number, int expected)
  {
    var calculator = new Calculator();

    var result = calculator.Add(number);

    Assert.Equal(result, expected);
  }

}
