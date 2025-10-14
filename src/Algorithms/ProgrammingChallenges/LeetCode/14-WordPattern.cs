namespace ProgrammingChallenges.LeetCode;

public static class WordPattern
{
    /*
    1) Given a pattern and a string s, find if s follows the same pattern.

        Here follow means a full match, such that there is a bijection between a letter 
        in pattern and a non-empty word in s. Specifically:

        Each letter in pattern maps to exactly one unique word in s.
        Each unique word in s maps to exactly one letter in pattern.
        No two letters map to the same word, and no two words map to the same letter.
        
        Input: pattern = "abba", s = "dog cat cat dog"
        Output: true

        a -> dog
        b -> cat
        b -> cat
        a -> dog
    
    2) split by empty space 's' to get the words
    3) if words.length != than pattern.length then return false, it should 
        have the same length
    4) create a map to store the characters and the words
    5) loop through pattern
        5.1) if map doesnt contains the key of pattern[i], then check foreach word
            in map if its value is equals to words[i], if true then return false bc
            it means that there's already a value with the word's key
        5.2) add pattern and words to the map
        5.3) if map[pattern[i]] is different than words[i] return false bc
            it means that there's a mapping but the values are different
    6) otherwise return true
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
            else if (map[pattern[i]] != words[i])
                return false;
        }

        return true;
    }
}
