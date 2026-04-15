public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>(); //{num: index}

        for(int i = 0; i < nums.Length; i++){
            int cmp = target - nums[i];

            if(seen.ContainsKey(cmp))
                return new int[] {seen[cmp], i};
            
            seen[nums[i]] = i;
        }

        return new int[0];
    }
}
