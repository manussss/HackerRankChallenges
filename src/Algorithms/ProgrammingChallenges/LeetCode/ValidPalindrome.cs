using System.Text.RegularExpressions;

namespace ProgrammingChallenges.LeetCode;

public static class ValidPalindrome
{
    /*
    A phrase is a palindrome if, after converting all uppercase letters 
    into lowercase letters and removing all non-alphanumeric characters, 
    it reads the same forward and backward. Alphanumeric characters include 
    letters and numbers. 
     */
    public static bool IsPalindrome(string s)
    {
        var phrase = RemoveNonAlphanumeric(s.ToLower());

        if (string.IsNullOrEmpty(phrase)) return true;

        var reversed = new string(phrase.Reverse().ToArray());

        return phrase == reversed;
    }

    private static string RemoveNonAlphanumeric(string input)
    {
        return Regex.Replace(input, "[^a-zA-Z0-9]", "");
    }
}
