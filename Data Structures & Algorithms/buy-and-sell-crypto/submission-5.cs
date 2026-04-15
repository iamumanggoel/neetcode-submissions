public class Solution {
    public int MaxProfit(int[] prices) {

        if(prices.Length <= 1) return 0;
        int min = prices[0], profit = 0;

        for(int i = 1; i < prices.Length; i++){
            
            profit = Math.Max(prices[i] - min, profit);

            min = Math.Min(min, prices[i]);
        }

        return profit;
    }
}
