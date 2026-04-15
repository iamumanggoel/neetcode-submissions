public class Solution {
    public int Trap(int[] height) {
        int n = height.Length, result = 0;

        int i = 0, j = n - 1,  prefix = height[i], suffix = height[j];

        while(i < j){
            if(prefix < suffix){
                i++;
                prefix = Math.Max(prefix, height[i]);
                result += prefix - height[i];
            }
            else{
                j--;
                suffix = Math.Max(suffix, height[j]);
                result += suffix - height[j];
            }
        }
        return result;
    }
}
