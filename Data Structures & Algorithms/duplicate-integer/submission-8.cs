public class Solution {
    public bool hasDuplicate(int[] nums) {
        var seen = new HashSet<int>(nums);
        return seen.Count < nums.Length;
        
    }
}