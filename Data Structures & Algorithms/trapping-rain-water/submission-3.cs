public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        var prefix = new int[n];
        var suffix = new int[n];
        var result = 0;
        
        prefix[0] = height[0];
        for(int i = 1; i < n; i++){
            prefix[i] = Math.Max(height[i], prefix[i-1]); 
        }

        suffix[n-1] = height[n-1];
        for(int i = n - 2; i >= 0; i--){
            suffix[i] = Math.Max(height[i], suffix[i+1]);
        }

        for(int i = 0; i < n; i++){
            int trappable = Math.Min(suffix[i], prefix[i]) - height[i];

            if(trappable > 0)
                result += trappable;
        }

        return result;
    }
}
