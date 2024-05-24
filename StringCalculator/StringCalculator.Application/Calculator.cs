namespace StringCalculator.Application;

public class Calculator
{
    public int Add(string numbers)
    {
        if (string.IsNullOrEmpty(numbers)) return 0;
        
        var splittedNumbers = numbers.Split(',', StringSplitOptions.RemoveEmptyEntries); 
        
        if (splittedNumbers.Length == 1) return int.Parse(splittedNumbers[0]);

        var sum = int.Parse(splittedNumbers[0]) + int.Parse(splittedNumbers[1]);
        return sum;
    }
}