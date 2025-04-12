namespace ProgrammingChallenges.LeetCode;

public static class RomanToInteger
{
    /* Roman numbers are written backwards

    MCMXCIV

    Start by the end => V
    V < 0 ? No, then sum
    Go to I
    I < V ? Yes, then subtract
    C < I ? No, then sum
    X < C ? Yes, then subtract
    ...

    MCMXCIV
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
