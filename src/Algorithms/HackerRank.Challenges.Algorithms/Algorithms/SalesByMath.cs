namespace HackerRank.Challenges.Algorithms.Algorithms;

public static class SalesByMath
{
    /*
    There is a large pile of socks that must be paired by color. 
    Given an array of integers representing the color of each sock, 
    determine how many pairs of socks with matching colors there are. 

    1 - Agrupar por grupos de "cores" (numeros iguais)
    2 - se a contagem do grupo atual for divisivel por 2, significa que temos um par
    2 - Retornar quantidade de pares
     */
    public static int GetSockMerchantPairs(int socksLenght, List<int> colors)
    {
        var lookup = new Dictionary<int, List<int>>();
        var pairs = 0;

        foreach (var item in colors)
        {
            if (!lookup.TryGetValue(item, out var group))
            {
                group = [];
                lookup[item] = group;
            }

            group.Add(item);

            if (group.Count % 2 == 0)
                pairs++;
        }

        return pairs;
    }
}
