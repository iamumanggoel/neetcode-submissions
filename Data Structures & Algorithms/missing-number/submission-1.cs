public class Solution {
    public int MissingNumber(int[] nums) {
        
        var seen = new HashSet<int>(nums);
        for(int i = 0; i < nums.Length; i++){
            if(!seen.Contains(i))
                return i;
        }

        return nums.Length;
    }
}
