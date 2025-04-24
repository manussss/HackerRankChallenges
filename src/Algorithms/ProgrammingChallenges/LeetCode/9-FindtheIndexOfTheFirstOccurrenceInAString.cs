namespace ProgrammingChallenges.LeetCode;

public static class FindtheIndexOfTheFirstOccurrenceInAString
{
    /*
    Given two strings needle and haystack, 
    return the index of the first occurrence of 
    needle in haystack, or -1 if needle is not part of haystack. 

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
