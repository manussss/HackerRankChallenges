namespace ProgrammingChallenges.LeetCode;

public static class HappyNumber
{
    /*
    1) Write an algorithm to determine if a number n is happy.
        A happy number is a number defined by the following process:
        Starting with any positive integer, replace the number by the sum of the 
        squares of its digits.
        Repeat the process until the number equals 1 (where it will stay), 
        or it loops endlessly in a cycle which does not include 1.
        Those numbers for which this process ends in 1 are happy.
        Return true if n is a happy number, and false if not.

    2) check if 'n' equals 1, if true then return true
    3) create a hash to store the numbers that were seen
    4) while 'n' not equals 1, then
        4.1) create a variable sum starting at 0
        4.2) foreach n, calculate the square of its digits then add it up to sum
        4.3) if your hashset has seen its number, then return false, otherwise
            add the sum to the hashset
        4.4) set 'n' = sum bc now this is the input for the algorithm
    5) return true by then end
     */
    public static bool IsHappy(int n)
    {
        if (n == 1)
            return true;

        var hash = new HashSet<int>();

        while (n != 1)
        {
            var sum = 0;

            foreach (var number in n.ToString())
            {
                sum += (number - '0') * (number - '0');
            }

            if (hash.Contains(sum))
                return false;

            hash.Add(sum);

            n = sum;
        }

        return true;      
    }
}
