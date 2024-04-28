namespace LeapYearKata.Application;

public class YearCalculator
{
    public bool IsLeapYear(int year) => 
        IsYearDivisibleBy(year, 100) ? IsYearDivisibleBy(year, 400) : IsYearDivisibleBy(year, 4);

    private static bool IsYearDivisibleBy(int year, int value)
    {
        return year % value == 0;
    }
}