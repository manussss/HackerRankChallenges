namespace ProgrammingChallenges.ManningAlgorithms;

public static class BinarySearch
{
    //Input -> Sorted List
    //Output -> index of the element you search, null if its not on the list
    public static int? Search(int[] numbers, int elementToFind)
    {
        var minimum = 0;
        var maximum = numbers.Length - 1;

        while (minimum < maximum)
        {
            var half = (minimum + maximum) / 2;
            var guess = numbers[half];

            if (guess == elementToFind)
                return half;

            else if (guess < elementToFind)
                minimum = half + 1;

            else if (guess > elementToFind)
                maximum = half - 1;
        }

        return null;
    }
}
