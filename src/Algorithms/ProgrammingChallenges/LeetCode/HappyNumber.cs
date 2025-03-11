namespace ProgrammingChallenges.LeetCode;

public static class HappyNumber
{
    /*
    Write an algorithm to determine if a number n is happy.

    A happy number is a number defined by the following process:

    Starting with any positive integer, replace the number by the sum of the squares of its digits.
    Repeat the process until the number equals 1 (where it will stay), or it loops endlessly in a cycle which does not include 1.
    Those numbers for which this process ends in 1 are happy.
    Return true if n is a happy number, and false if not.
     */
    public static bool IsHappy(int n)
    {
        if (n == 1)
            return true;

        HashSet<int> seenNumbers = [];

        while (n != 1)
        {
            var sum = 0;

            foreach (char c in n.ToString())
            {
                sum += (c - '0') * (c - '0');
            }

            if (seenNumbers.Contains(sum))
                return false;

            seenNumbers.Add(sum);

            n = sum;
        }

        return true;
    }
}
