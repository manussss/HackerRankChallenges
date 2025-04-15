namespace ProgrammingChallenges.LeetCode;

public static class LongestCommonPrefix
{
    /*
    Write a function to find the longest common prefix string amongst an array of strings.

    If there is no common prefix, return an empty string "".

    Example 1:

    Input: strs = ["flower","flow","flight"]
    Output: "fl"
    Example 2:

    Input: strs = ["dog","racecar","car"]
    Output: ""
    Explanation: There is no common prefix among the input strings. 
     */
    public static string GetLongestCommonPrefix(string[] strs)
    {
        if (strs == null || strs.Length == 0)
            return string.Empty;

        var prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (prefix == string.Empty)
                    return string.Empty;
            }
        }

        return prefix;
    }
}
