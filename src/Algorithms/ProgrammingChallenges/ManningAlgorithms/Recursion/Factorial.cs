namespace ProgrammingChallenges.ManningAlgorithms.Recursion;

public static class Factorial
{
    /*
    number = 3
    F(3) = 6

    1) 3, return 3 * GetFactorial(2)
    2) 2, return 2 * GetFactorial(1)
    3) 1, return 1

    3) returned 1
    2) returned 2, then 2 * 1 => 2
    1) returned 2, then 2 * 3 => 6
    
    */
    public static int GetFactorial(int number)
    {
        if (number == 1)
            return 1;
        else
            return number * GetFactorial(number - 1);
    }
}