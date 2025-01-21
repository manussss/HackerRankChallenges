namespace HackerRank.Challenges.Algorithms.Algorithms;

public static class FindDigits
{
    /*
    input 124
    
    divide 124 by each number
    124 / 1
    124 / 2
    124 / 4

    if % == 0, then divisor++
     
     */
    public static int GetDivisors(int number)
    {
        var divisors = 0;
        var digits = number
            .ToString()
            .Select(c => (int)char.GetNumericValue(c));

        foreach (var digit in digits)
        {
            if (digit == 0)
                continue;

            if (number % digit == 0)
                divisors++;
        }

        return divisors;
    }
}
