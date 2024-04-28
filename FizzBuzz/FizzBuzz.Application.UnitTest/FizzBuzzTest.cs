using FluentAssertions;

namespace FizzBuzzShould;

[TestFixture]
public class FizzBuzzTest
{
    private const string Fizz = "Fizz";
    private const string Buzz = "Buzz";

    [TestCase(1,"1")]
    [TestCase(2,"2")]
    [TestCase(4,"4")]
    public void convert_number_to_string(int number, string expected)
    {
        var fizzBuzz = new FizzBuzz.Application.FizzBuzz();
        
        var result = fizzBuzz.Convert(number);

        result.Should().Be(expected);
    }
    
    [TestCase(3)]
    [TestCase(6)]
    [TestCase(9)]
    public void convert_number_to_Fizz(int number)
    {
        var fizzBuzz = new FizzBuzz.Application.FizzBuzz();
        
        var result = fizzBuzz.Convert(number);

        result.Should().Be(Fizz);
    }
    
    [TestCase(5)]
    [TestCase(10)]
    [TestCase(20)]
    public void convert_number_to_Buzz(int number)
    {
        var fizzBuzz = new FizzBuzz.Application.FizzBuzz();
        
        var result = fizzBuzz.Convert(number);

        result.Should().Be(Buzz);
    }
    
    [TestCase(15)]
    [TestCase(30)]
    [TestCase(60)]
    public void convert_number_to_FizzBuzz(int number)
    {
        var fizzBuzz = new FizzBuzz.Application.FizzBuzz();
        
        var result = fizzBuzz.Convert(number);

        result.Should().Be($"{Fizz}{Buzz}");
    }
}
