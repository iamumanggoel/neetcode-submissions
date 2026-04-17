public class Solution {
    public int MaxProfit(int[] prices) {
        if(prices.Length <= 1) return 0;
        int maxProfit = 0;
        int n = prices.Length;
        var postMax = new int[n];

        postMax[n - 1] = prices[n-1];
        for(int i = n - 2; i >=0; i--){
            postMax[i] = Math.Max(postMax[i+1], prices[i+1]);
        }

        for(int i = 0; i < n - 1; i++){
            var potentialProfit = postMax[i] - prices[i];
            if(potentialProfit > 0)
                maxProfit = Math.Max(potentialProfit, maxProfit);
        }

        return maxProfit;
    }
}
