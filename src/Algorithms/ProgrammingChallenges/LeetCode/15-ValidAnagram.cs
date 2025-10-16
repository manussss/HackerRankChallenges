namespace ProgrammingChallenges.LeetCode;

public static class ValidAnagram
{
    /*
    1) Given two strings s and t, return true if t is an anagram of s, and false otherwise
        Using all of the characters in 's'we can create 't'

    2) Create two dics for each input
    3) map 's' and how many ocurrences it has
    4) map 't' and how many ocurrences it has
    5) foreach 's', check if 't' has its key (if it doesnt, then return false)
        5.1) also check if t's value is the same as s's value, if its not, the return false
    
    Input: s = "anagram", t = "nagaram"
    Output: true

    Input: s = "rat", t = "car"
    Output: false
     */
    public static bool IsAnagram(string s, string t)
    {
        if (s.Length != t.Length)
            return false;

        Dictionary<char, int> sMap = new(s.Length);
        Dictionary<char, int> tMap = new(t.Length);

        for (int i = 0; i < s.Length; i++)
        {
            if (!sMap.TryGetValue(s[i], out int value))
                sMap.Add(s[i], 1);
            else
                sMap[s[i]] = ++value;
        }

        for (int i = 0; i < t.Length; i++)
        {
            if (!tMap.TryGetValue(t[i], out int value))
                tMap.Add(t[i], 1);
            else
                tMap[t[i]] = ++value;
        }

        foreach (var sMapItem in sMap)
        {
            if (!tMap.TryGetValue(sMapItem.Key, out int value))
                return false;

            if (value != sMapItem.Value)
                return false;
        }

        return true;
    }
}
