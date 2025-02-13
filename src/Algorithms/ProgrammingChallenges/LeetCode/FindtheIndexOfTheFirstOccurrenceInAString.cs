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
        for (var i = 0; i <= haystack.Length - needle.Length; i++)
        {
            var match = true;

            for (var j = 0; j < needle.Length; j++)
            {
                if (haystack[i + j] != needle[j])
                {
                    match = false;
                    break;
                }
            }

            if (match)
                return i;
        }

        return -1;
    }
}
