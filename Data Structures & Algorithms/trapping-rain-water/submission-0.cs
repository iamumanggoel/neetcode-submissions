public class Solution {
    public int Trap(int[] height) {
        int n = height.Length;
        var prefixMax = new int[n];
        var suffixMax = new int[n];
        var result = 0;

        prefixMax[0] = height[0];
        for(int i = 1; i < n; i++)
            prefixMax[i] = Math.Max(prefixMax[i-1], height[i]);
        
        suffixMax[n-1] = height[n-1];
        for(int i = n-2; i >= 0; i--)
            suffixMax[i] = Math.Max(suffixMax[i+1], height[i]);
        
        for(int i = 0; i < n; i++){
            int water = Math.Min(prefixMax[i], suffixMax[i]) - height[i];

            if(water > 0)
                result += water;
        }

        return result;
    }
}
