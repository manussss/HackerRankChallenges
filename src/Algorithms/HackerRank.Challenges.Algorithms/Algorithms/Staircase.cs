using System.Text;

namespace HackerRank.Challenges.Algorithms.Algorithms;

/*
floors = 6
 
staircase = ""
staircase = "12345#"
staircase = "1234##"
staircase = "123###"
staircase = "12####"
staircase = "1#####"
staircase = "######"
 */
public static class Staircase
{
    public static string GetStaircase(int floors)
    {
        var staircase = new StringBuilder();
        var sharp = '#';

        for (int i = 1; i <= floors; i++)
        {
            var stair = new string(sharp, i);
            staircase.Append($"{stair.PadLeft(floors)}\r\n");
        }

        return staircase.ToString();
    }
}
