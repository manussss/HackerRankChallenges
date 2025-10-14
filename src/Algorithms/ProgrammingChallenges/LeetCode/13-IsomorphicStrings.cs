namespace ProgrammingChallenges.LeetCode;

public static class IsomorphicStrings
{
    /*
    1) Given two strings s and t, determine if they are isomorphic.
        Two strings s and t are isomorphic if the characters in s can 
        be replaced to get t. All occurrences of a character must be 
        replaced with another character while preserving the order of 
        characters. No two characters may map to the same character, but a 
        character may map to itself.
        Ex. 'add' -> 'egg'
        'a' -> 'e'
        'd' -> 'g'
    
    2) create a map to store the characters
    3) loop through one of the strings
        3.1) if the map doesnt contains the key, then check each value of the map if its
            equals to the other string[i], if true then return false
        3.2) add s[i] and t[i] to the map
        3.3) if the map contains the key, then check if map[s[i]] its different than
            t[i], if true then return false
    4) otherwise return true
     */
    public static bool IsIsomorphic(string s, string t)
    {
        Dictionary<char, char> map = [];

        for (int i = 0; i < s.Length; i++)
        {
            if (!map.ContainsKey(s[i]))
            {
                foreach (var isomorph in map)
                {
                    if (isomorph.Value == t[i])
                        return false;
                }

                map.Add(s[i], t[i]);
            }
            else if (map[s[i]] != t[i])
                return false;
        }

        return true;
    }
}
