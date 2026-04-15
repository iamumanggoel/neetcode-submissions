public class Solution {
    public int MaxProfit(int[] prices) {
        var result = 0;

        int i = 0, j = 1;

        while(j < prices.Length){
            if(prices[i] < prices[j]){
                result = Math.Max(result, prices[j] - prices[i]);
            }
            else{
                i = j;
            }

            j++;
        }
        return result;
    }
}
