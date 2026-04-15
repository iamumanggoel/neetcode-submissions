public class Solution {
    public int FindDuplicate(int[] nums) {
        var seen = new HashSet<int>();

        foreach(int num in nums){
            if(!seen.Add(num))
                return num;
        }

        return -1;
    }
}
