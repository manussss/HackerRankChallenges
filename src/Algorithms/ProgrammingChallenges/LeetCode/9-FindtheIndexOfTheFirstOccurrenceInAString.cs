namespace ProgrammingChallenges.LeetCode;

public static class FindtheIndexOfTheFirstOccurrenceInAString
{
    /*
    1) Given two strings needle and haystack, return the index of the first occurrence of 
        needle in haystack, or -1 if needle is not part of haystack.
    2) start with an aux = 0
    3) loop through haystack while it doesnt start with needle
        3.1) if it doesnt, remove the first character
        3.2) increment aux to store the index
        3.3) if haystack is null or empty, return -1
        3.4) otherwise return aux

    Input: haystack = "sadbutsad", needle = "sad"
    Output: 0
     */
    public static int GetIndexOfTheFirstOccurrence(string haystack, string needle)
    {
        var aux = 0;

        while (!haystack.StartsWith(needle))
        {
            haystack = haystack[1..];
            aux++;

            if (string.IsNullOrEmpty(haystack))
                return -1;
        }

        return aux;
    }
}
