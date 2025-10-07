namespace ProgrammingChallenges.LeetCode;

public static class LongestCommonPrefix
{
    /*
    1) Write a function to find the longest common prefix string amongst an array of strings.
        If there is no common prefix, return an empty string "".
    2) check if array is null or count == 0, if so, return
    3) store the first string of the array
    4) loop through the array starting at 1
    5) while array[i] doesnt start with the first string of the array (index 0), 
        remove the last character from the first string of the array
    5.1) throughout the loop, check if the first string of the array is null or empty to
        avoid exceptions

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
        if (strs is null || strs.Length == 0)
            return string.Empty;

        var prefix = strs[0];

        for (int i = 1; i < strs.Length; i++)
        {
            while (!strs[i].StartsWith(prefix))
            {
                prefix = prefix.Substring(0, prefix.Length - 1);

                if (string.IsNullOrEmpty(prefix))
                    return string.Empty;
            }
        }

        return prefix;
    }
}
