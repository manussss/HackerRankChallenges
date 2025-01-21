namespace ProgrammingChallenges.HackerRank
{
    public static class AppleAndOrange
    {
        //The apple tree is to the left of the house, and the orange tree is to its right.
        //When a fruit falls from its tree, it lands  units of distance from its tree of origin along the -axis.
        //*A negative value of  means the fruit fell  units to the tree's left,
        //and a positive value of  means it falls  units to the tree's right. *
        public static List<int> CountApplesAndOranges(int start, int end, int appleLocation, int orangeLocation, List<int> apples, List<int> oranges)
        {
            var applesInArea = 0;
            var orangesInArea = 0;

            for (int i = 0; i < apples.Count; i++)
            {
                var distance = apples[i] + appleLocation;
                if (distance >= start && distance <= end)
                    applesInArea++;
            }

            for (int i = 0; i < oranges.Count; i++)
            {
                var distance = oranges[i] + orangeLocation;
                if (distance >= start && distance <= end)
                    orangesInArea++;
            }

            return [applesInArea, orangesInArea];
        }
    }
}