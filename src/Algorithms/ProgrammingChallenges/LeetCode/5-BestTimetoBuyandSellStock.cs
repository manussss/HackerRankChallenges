namespace ProgrammingChallenges.LeetCode;

public static class BestTimetoBuyandSellStock
{
    /*
    1) You are given an array prices where prices[i] is the price of a given stock on the 
        ith day. You want to maximize your profit by choosing a single day to buy one stock 
        and choosing a different day in the future to sell that stock.
        Return the maximum profit you can achieve from this transaction.
        If you cannot achieve any profit, return 0. 
    
    1.1) return the maximum profit given the input nums. 
        the maximum profit is price - lowest price > highest previous profit
    2) iterate through prices
    3) if price is < previous lowest price, then assign price to lowest price
    4) if price - lowest price > highest profit, then assign it to highest profit
    5) return highest profit

    [7, 1, 5, 3, 6, 4]
     */
    public static int GetMaxProfit(int[] prices)
    {
        var maxProfit = 0;
        var minPrice = prices[0];

        for (int i = 1; i < prices.Length; i++)
        {
            if (prices[i] < minPrice)
                minPrice = prices[i];

            if ((prices[i] - minPrice) > maxProfit)
                maxProfit = prices[i] - minPrice;
        }

        return maxProfit;
    }
}
