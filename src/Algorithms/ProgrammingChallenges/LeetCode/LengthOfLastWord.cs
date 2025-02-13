namespace ProgrammingChallenges.LeetCode;

public static class LengthOfLastWord
{
    /*
    Given a string s consisting of words and spaces, return the length of the last word in the string.

    A word is a maximal substring consisting of non-space characters only.
     */
    public static int GetLengthOfLastWord(string s)
    {
        return s.Split(' ').Where(s => !string.IsNullOrEmpty(s)).Last().Length;
    }
}
