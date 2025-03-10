namespace ProgrammingChallenges.LeetCode;

public static class ValidAnagram
{
    /*
    Given two strings s and t, return true if t is an anagram of s, and false otherwise.
    
    Input: s = "anagram", t = "nagaram"
    Output: true

    Input: s = "rat", t = "car"
    Output: false
     */
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        List<char> tAsList = [.. t];

        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 0; j < tAsList.Count; j++)
            {
                if (s[i] == tAsList[j])
                {
                    tAsList.RemoveAt(j);
                    break;
                }
            }
        }

        return tAsList.Count == 0;
    }
}
