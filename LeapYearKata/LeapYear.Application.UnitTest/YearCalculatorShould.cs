using LeapYearKata.Application;
using FluentAssertions;

namespace LeapYear.Application.UnitTest;

public class YearCalculatorShould
{
    
    [Test]
    public void be_normal_year_when_is_not_divisible_by_four()
    {
        var leapYear = new YearCalculator();
        
        var result = leapYear.IsLeapYear(1997);
        
        result.Should()
            .BeFalse();
    }
    
    [Test]
    public void be_leap_year_when_is_divisible_by_four()
    {
        var leapYear = new YearCalculator();
        
        var result = leapYear.IsLeapYear(1996);
        
        result.Should()
            .BeTrue();
    }
    
    [Test]
    public void be_leap_year_when_is_divisible_by_four_hundred()
    {
        var leapYear = new YearCalculator();
        
        var result = leapYear.IsLeapYear(1600);
        
        result.Should()
            .BeTrue();
    }
    
    [Test]
    public void be_leap_year_when_is_divisible_by_one_hundred_and_not_by_four_hundred()
    {
        var leapYear = new YearCalculator();
        
        var result = leapYear.IsLeapYear(1800);
        
        result.Should()
            .BeFalse();
    }
}