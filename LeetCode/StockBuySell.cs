public class Solution
{
    public int MaxProfitInO(int[] prices)
    {
        int minPrice = Int32.MaxValue;
        int maxProfit = 0;

        for (int i = 0; i < prices.Length; i++)
        {
            minPrice = Math.Min(minPrice, prices[i]);
            int profit = prices[i] - minPrice;
            maxProfit = Math.Max(maxProfit, profit);
        }
        return maxProfit;

    }
}