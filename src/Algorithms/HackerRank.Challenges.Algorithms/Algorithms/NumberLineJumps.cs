namespace HackerRank.Challenges.Algorithms.Algorithms
{
    public static class NumberLineJumps
    {
        /*
        formula: speed = distance / jumps (time)
        =>
        distance = speed * jumps
        =>
        total distance 1 = (speed1 * jumps) + start1
        total distance 2 = (speed2 * jumps) + start2
        =>
        start1 + (speed1 * jumps) = start2 + (speed2 * jumps)
        =>
        jumps * (speed1 - speed2) = start2 - start1
        =>
        jumps = (start2 - start1) / (speed1 - speed2)
        if jumps = 0, then it means they will meet at some point
         */
        public static string WillKangoroosMeet(int start1, int speed1, int start2, int speed2)
        {
            if (speed1 <= speed2)
                return "NO";

            return (start2 - start1) % (speed1 - speed2) == 0 ? "YES" : "NO";
        }
    }
}
