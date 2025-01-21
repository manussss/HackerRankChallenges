namespace ProgrammingChallenges.HackerRank
{
    public static class CatsAndAMouse
    {
        public static string GetCatsVersusMouse(int catAPosition, int catBPosition, int mousePosition)
        {
            var distanceToCatA = Math.Abs(mousePosition - catAPosition);
            var distanceToCatB = Math.Abs(mousePosition - catBPosition);

            if (distanceToCatA == distanceToCatB)
                return "Mouse C";

            return distanceToCatA > distanceToCatB ? "Cat B" : "Cat A";
        }
    }
}
