namespace ProgrammingChallenges.LeetCode;

public static class WordPattern
{
    /*
    Given a pattern and a string s, find if s follows the same pattern.

    Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s. Specifically:

    Each letter in pattern maps to exactly one unique word in s.
    Each unique word in s maps to exactly one letter in pattern.
    No two letters map to the same word, and no two words map to the same letter.
    
    Input: pattern = "abba", s = "dog cat cat dog"
    Output: true

    a -> dog
    b -> cat
    b -> cat
    a -> dog
     */
    public static bool IsWordPattern(string pattern, string s)
    {
        var words = s.Split(' ');

        if (pattern.Length != words.Length)
            return false;

        Dictionary<char, string> map = [];

        for (int i = 0; i < pattern.Length; i++)
        {
            if (!map.ContainsKey(pattern[i]))
            {
                foreach (var word in map)
                {
                    if (word.Value == words[i])
                        return false;
                }

                map.Add(pattern[i], words[i]);
            }
            else
            {
                if (map[pattern[i]] != words[i])
                    return false;
            }
        }

        return true;
    }
}
