namespace ProgrammingChallenges.LeetCode;

public static class IsSubsequence
{
    /*
    1) Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
        A subsequence of a string is a new string that is formed from the original 
        string by deleting some (can be none) of the characters without disturbing 
        the relative positions of the remaining characters. 
        (i.e., "ace" is a subsequence of "abcde" while "aec" is not).
    
    2) Create an aux variable starting at 0
    3) Loop through 'phrase'
        3.1) check is subsequence is null, empty or if the index aux variable is bigger than
            subsequence length, if true then break
        3.2) check if subsequence at the aux index is equal to phrase at [i], if true then
            increment aux
    4) return if subsequence length its equal to the index aux variable
     */
    public static bool IsSub(string subsequence, string phrase)
    {
        var subsequenceIndex = 0;

        for (int i = 0; i < phrase.Length; i++)
        {
            if (string.IsNullOrEmpty(subsequence) || (subsequenceIndex >= subsequence.Length))
                break;

            if (subsequence[subsequenceIndex] == phrase[i])
                subsequenceIndex++;
        }

        return subsequenceIndex == subsequence.Length;
    }
}
