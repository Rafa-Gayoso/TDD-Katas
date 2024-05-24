using FluentAssertions;

namespace StringCalculator.Application.UnitTest;

public class CalculatorShould
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
    
    [TestCase("2,3", 5, TestName = "two_numbers")]
    [TestCase("1,2,3", 6, TestName = "three_numbers")]
    [TestCase("5,7,12,30,20", 74, TestName = "five_numbers")]
    public void return_sum_of(string numbers, int expectedResult)
    {
        var result = _calculator.Add(numbers);
        result.Should().Be(expectedResult);
    }
}