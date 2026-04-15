public class Solution {
    public int MaxProfit(int[] prices) {
        var result = 0;
        var minBuy = prices[0];

        foreach(var price in prices){
            result = Math.Max(result, price - minBuy);
            minBuy = Math.Min(minBuy, price);
        }
        return result;
    }
}
