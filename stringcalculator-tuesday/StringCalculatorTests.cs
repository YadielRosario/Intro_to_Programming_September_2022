
namespace StringCalculator;

public class StringCalculatorTests
{
    [Fact]
    public void EmptyStringReturnsZero()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("");

        Assert.Equal(0, result);
    }

    [Fact]
    public void AddMoreThanTwoNumbers()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add("1,2,3,4,5,6");
        
        Assert.Equal(21, result);
    }

    [Fact]
    public void NumbersAreSeparatedByLinesAndCommas()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add($"1, 2 {Environment.NewLine} 3, 4 {Environment.NewLine} 5, 6 ");

        Assert.Equal(21, result);
    }

    [Fact]
    public void CustomDelimiterIsAccepted()
    {
        var calculator = new StringCalculator();

        var result = calculator.Add($"//;{Environment.NewLine} 1;2;3;4;5;6");

        Assert.Equal(21, result);
    }
}
