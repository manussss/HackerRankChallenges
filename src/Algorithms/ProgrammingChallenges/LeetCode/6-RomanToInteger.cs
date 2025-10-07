namespace ProgrammingChallenges.LeetCode;

public static class RomanToInteger
{
    /* 
    
    1) Translate roman numbers to integer numbers
    1.1) Roman numbers are written backwards
    2) Create a map <roman, integer>
    3) Loop through the numbers backwards
    4) Subtract the sum if the 'current' number is smaller than the 'previous'
    5) Increase the sum if the 'current' number is bigger than the 'previous'

    MCMXCIV

    Start by the end => V
    V < 0 ? No, then sum
    Go to I
    I < V ? Yes, then subtract
    C < I ? No, then sum
    X < C ? Yes, then subtract
    ...
   */
    public static int TranslateRomanToInt(string s)
    {
        Dictionary<char, int> map = new()
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

        var sum = 0;
        var previous = 0;

        for (int i = s.Length - 1; i >= 0; i--)
        {
            var current = map[s[i]];

            if (current < previous)
                sum -= current;
            else
                sum += current;

            previous = current;
        }

        return sum;
    }
}
