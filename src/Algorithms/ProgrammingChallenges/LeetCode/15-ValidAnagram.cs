namespace ProgrammingChallenges.LeetCode;

public static class ValidAnagram
{
    /*
    1) Given two strings s and t, return true if t is an anagram of s, and false otherwise
        Using all of the characters in 's'we can create 't'

    2) sort S
    3) sort T
    4) loop through s or t and check if s[i] != t[i]
        4.1) if the condition above is true, it means its not an anagram, return false
    5) otherwise return true
    
    Input: s = "anagram", t = "nagaram"
    Output: true

    Input: s = "rat", t = "car"
    Output: false
     */
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        var sortedS = s.OrderBy(a => a);
        var sortedT = t.OrderBy(t => t);

        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] != t[i])
                return false;
        }

        return true;
    }
}
