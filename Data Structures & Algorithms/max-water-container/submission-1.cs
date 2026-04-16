public class Solution {
    public int MaxArea(int[] heights) {
        int i = 0, j = heights.Length - 1;
        int max = 0;

        while(i < j){
            int height = Math.Min(heights[i], heights[j]);
            int length = j - i;
            int area = height * length;
            max = Math.Max(max, area);

            if(heights[i] <= heights[j]){
                i++;
            }
            else{
                j--;
            }

            
        }

        return max;
    }
}
