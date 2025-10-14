namespace ProgrammingChallenges.LeetCode;

public static class RansomNote
{
    /*
    1) Given two strings ransomNote and magazine, return true if ransomNote 
        can be constructed by using the letters from magazine and false otherwise.
        Each letter in magazine can only be used once in ransomNote.
    
    2) store ransomNote length on a variable bc later you'll decrease its value
    3) create an aux variable starting at 0, it will store how many equal characters it has
    4) loop through 'magazine'
        4.1) check if the aux variable and the legnth one are equal, if true, then return true
        4.2) loop through 'ransomNote'
            4.2.1) check if ransomNote[j] == magazine[i], if true then:
            4.2.2) remove the last character from ransomNote
            4.2.3) increment the variable that stores the same characters
            4.2.4) break the inner loop
    5) return if ransom note length its equals to the aux variable with the same characters
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
