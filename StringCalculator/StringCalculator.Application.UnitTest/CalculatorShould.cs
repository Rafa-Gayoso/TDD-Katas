using FluentAssertions;

namespace StringCalculator.Application.UnitTest;

public class Tests
{
    private Calculator _calculator;

    [SetUp]
    public void Setup()
    {
        _calculator = new Calculator();
    }

    [Test]
    public void return_zero_when_no_numbers_were_provided()
    {
        var result = _calculator.Add("");
        result.Should().Be(0);
    }
    
    [Test]
    public void return_number_when_only_one_number_is_provided()
    {
        var result = _calculator.Add("1 ");
        result.Should().Be(1);
    }
    
    [Test]
    public void return_sum_of_two_numbers()
    {
        var result = _calculator.Add("2,3");
        result.Should().Be(5);
    }
}