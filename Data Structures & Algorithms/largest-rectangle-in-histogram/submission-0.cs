public class Solution {
    public int LargestRectangleArea(int[] heights) {
        int area = 0;

        for(int i = 0; i < heights.Length; i++){

            int left = i;

            while(left >= 0 && heights[left] >= heights[i])
                left--;
            

            int right = i+1;

            while(right < heights.Length && heights[right] >= heights[i])
                right++;

            area = Math.Max(area, heights[i] * ((right-1)-(left+1) +1));
            
        }

        return area;
    }
}

