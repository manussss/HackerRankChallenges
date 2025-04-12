namespace ProgrammingChallenges.LeetCode;

public static class LengthOfLastWord
{
    /*
    Given a string s consisting of words and spaces, return the length of 
    the last word in the string.

    A word is a maximal substring consisting of non-space characters only.
     */
    public static int GetLengthOfLastWord(string s)
    {
        var words = s.Split(' ');
        var length = 0;

        for (int i = words.Length - 1; i >= 0; i--)
        {
            if (string.IsNullOrEmpty(words[i]))
                continue;
            else
            {
                length = words[i].Length;
                break;
            }
        }

        return length;
    }
}
