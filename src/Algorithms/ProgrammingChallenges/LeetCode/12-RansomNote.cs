namespace ProgrammingChallenges.LeetCode;

public static class RansomNote
{
    /*
    Given two strings ransomNote and magazine, return true if ransomNote 
    can be constructed by using the letters from magazine and false otherwise.

    Each letter in magazine can only be used once in ransomNote. 
     */
    public static bool CanConstruct(string ransomNote, string magazine)
    {
        var ransomNoteLength = ransomNote.Length;
        var sameCharactersAmount = 0;

        for (var i = 0; i < magazine.Length; i++)
        {
            if (ransomNoteLength == sameCharactersAmount)
                return true;

            for (int j = 0; j < ransomNote.Length; j++)
            {
                if (magazine[i] == ransomNote[j])
                {
                    sameCharactersAmount++;
                    ransomNote = ransomNote.Remove(j, 1);
                    break;
                }
            }
        }

        return ransomNoteLength == sameCharactersAmount;
    }
}
