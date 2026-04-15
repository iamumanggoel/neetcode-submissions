public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length <= 1)
            return nums.Length;

        var numSet = new HashSet<int>(nums);
        var max = -1;

        for(int i = 0; i < nums.Length; i++){
            if(numSet.Contains(nums[i] - 1))
                continue;
            
            int currLen = 1;
            int currNum = nums[i];
            while(numSet.Contains(currNum + 1)){
                currNum++;
                currLen++;
            }
            max = Math.Max(max, currLen);
            
        }

        return max;
    }
}
