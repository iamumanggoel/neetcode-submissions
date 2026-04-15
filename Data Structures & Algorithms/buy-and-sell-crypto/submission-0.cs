public class Solution {
    public int MaxProfit(int[] prices) {
        var result = 0;

        for(int i = 0; i < prices.Length - 1; i++){
            for(int j = i + 1; j < prices.Length; j++){
                result = Math.Max(result, prices[j] - prices[i]);
            }
        }

        return result;
    }
}
