namespace ProgrammingChallenges.LeetCode;

public static class ValidAnagram
{
    /*
    1) Given two strings s and t, return true if t is an anagram of s, and false otherwise
        Using all of the characters in 's'we can create 't'
    
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
            if (!tMap.ContainsKey(sMapItem.Key))
                return false;

            if (tMap[sMapItem.Key] != sMapItem.Value)
                return false;
        }

        return true;
    }
}
