using FluentAssertions;

namespace StringCalculator.Application.UnitTest;

public class Tests
{
    [SetUp]
    public void Setup()
    {
    }

    [Test]
    public void return_zero_when_no_numbers_were_provided()
    {
        var calculator = new Calculator();
        var result = calculator.Add("");
        result.Should().Be(0);
    }
    
    [Test]
    public void return_number_when_only_one_number_is_provided()
    {
        var calculator = new Calculator();
        var result = calculator.Add("1");
        result.Should().Be(1);
    }
}