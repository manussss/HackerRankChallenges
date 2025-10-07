namespace ProgrammingChallenges.LeetCode;

public static class LengthOfLastWord
{
    /*
    1) Given a string s consisting of words and spaces, return the length of 
        the last word in the string.
    1.1) A word is a maximal substring consisting of non-space characters only.
    2) Split the input for empty spaces
    3) Loop through the words backwards
    4) if the word is not null or empty, return its length
     */
    public static int GetLengthOfLastWord(string s)
    {
        var words = s.Split(' ');

        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (!string.IsNullOrEmpty(words[i]))
                return words[i].Length;
        }

        return 0;
    }
}
