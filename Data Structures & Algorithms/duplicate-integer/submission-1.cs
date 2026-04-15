public class Solution {
    public bool hasDuplicate(int[] nums) {
        var hash = new HashSet<int>();

        foreach(int num in nums){
            if(!hash.Add(num))
                return true;
        }
        return false;
    }
}