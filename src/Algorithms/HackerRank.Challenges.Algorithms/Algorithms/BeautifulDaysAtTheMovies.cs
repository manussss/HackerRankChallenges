namespace HackerRank.Challenges.Algorithms.Algorithms;

public static class BeautifulDaysAtTheMovies
{
    /*
    
    ao receber starting day e ending day, de um a outro preciso saber se ele - o inverso dele é divisivel pelo divisor, exemplo:

    startingDay = 20
    endingDay = 23
    divisor = 6

    20 - 02 / 6 = 0
    21 - 12 / 6 = 1.5
    22 - 22 / 6 = 0
    23 - 32 / 6 = 1.5

    Logo, apenas dois dias são "bonitos".
    
     */
    public static int GetBeautifulDays(int startingDay, int endingDay, int divisor)
    {
        var beautifulDays = 0;

        for (int i = startingDay; i <= endingDay; i++)
        {
            var inverse = int.Parse(new string(i.ToString().Reverse().ToArray()));

            if ((i - inverse) % divisor == 0) beautifulDays++;
        }

        return beautifulDays;
    }
}
