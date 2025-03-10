namespace ProgrammingChallenges.LeetCode;

public static class IsomorphicStrings
{
    /*
    Given two strings s and t, determine if they are isomorphic.

    Two strings s and t are isomorphic if the characters in s can be replaced to get t.

    All occurrences of a character must be replaced with another character while preserving 
    the order of characters. No two characters may map to the same character, but a character may map to itself.
     */
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                foreach (KeyValuePair<char, char> isomorph in map)
                {
                    if (isomorph.Value == t[i]) 
                        return false;
                }

                map.Add(s[i], t[i]);
            }
            else
            {
                if (map[s[i]] != t[i]) 
                    return false;
            }
        }

        return true;
    }
}
