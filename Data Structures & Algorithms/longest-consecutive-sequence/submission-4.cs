public class Solution {
    public int LongestConsecutive(int[] nums) {

        if(nums.Length <= 1) return nums.Length;
        
        var set = new HashSet<int>(nums);
        var longest = 1;

        foreach(int num in nums){
            
            set.Add(num);
            int candidate = num;
            int len = 1;
            while(set.Contains(candidate + 1)){
                candidate++;
                len++;
            }
            
            longest = Math.Max(longest, len);
            
        }
        
        return longest;

    }
}
