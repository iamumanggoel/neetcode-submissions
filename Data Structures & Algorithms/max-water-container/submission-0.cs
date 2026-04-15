public class Solution {
    public int MaxArea(int[] heights) {
       int i = 0, j = heights.Length - 1;
       int result = 0;
       while(i < j){
            result = Math.Max(result, Math.Min(heights[i], heights[j])*(j-i));
            if(heights[i] <= heights[j]){
                i++;
            }
            else{
                j--;
            }
       } 

       return result;
    }
}
