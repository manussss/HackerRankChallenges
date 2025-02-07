namespace ProgrammingChallenges.LeetCode;

public static class RomanToInteger
{
    public static int TranslateRomanToInt(string s)
    {
        var sum = 0;
        var previous = 0;

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
