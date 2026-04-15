public class Solution {
    public int FindMin(int[] nums) {
        int min = int.MaxValue;

        foreach(int num in nums){
            min = Math.Min(min, num);
        }

        return min;
    }
}
