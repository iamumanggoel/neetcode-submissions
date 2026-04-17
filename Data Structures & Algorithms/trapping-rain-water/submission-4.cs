public class Solution {
    public int Trap(int[] height) {
        var n = height.Length;
        var preMax = new int[n];
        preMax[0] = height[0];

        for(int i = 1; i < n; i++){
            preMax[i] = Math.Max(height[i-1], preMax[i-1]);
        }

        var postMax = new int[n];
        postMax[n - 1] = height[n-1];

        for(int i = n-2; i >= 0; i--)
            postMax[i] = Math.Max(height[i+1], postMax[i+1]);

        int area = 0;
        for(int i = 1; i < n - 1; i++){

            int currArea = Math.Min(preMax[i], postMax[i]) - height[i];
            if(currArea > 0) 
                area = area + currArea;
        }


        return area;
    }
}
