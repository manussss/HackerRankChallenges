namespace ProgrammingChallenges.HackerRank;

public static class PlusMinus
{
    /*
    Given an array of integers, calculate the ratios of its elements that are positive, negative, and zero. 
    Print the decimal value of each fraction on a new line with 6 places after the decimal. 

    Exemplo = [1, 1, 0, -1, -1]

    Há dois positivos de 5 elementos, logo 2/5 = 0.400000
    Há dois negativos de 5 elementos, logo 2/5 = 0.400000
    Há um zero de 5 elementos, logo 1/5 = 0.200000
     
     */
    public static string[] GetPlusMinus(List<int> arr)
    {
        double biggerThanZero = 0;
        double equalsZero = 0;
        double lessThanZero = 0;
        var arrCount = arr.Count;

        for (var i = 0; i < arrCount; i++) 
        {
            if (arr[i] == 0) equalsZero++;
            else if (arr[i] > 0) biggerThanZero++;
            else lessThanZero++;
        }

        return [(biggerThanZero/ arrCount).ToString("N6"), (equalsZero/arrCount).ToString("N6"), (lessThanZero/arrCount).ToString("N6")];
    }
}
