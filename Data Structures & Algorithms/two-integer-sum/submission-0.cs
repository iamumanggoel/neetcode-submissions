public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var cache = new Dictionary<int, int>(); //{nums[i], i}

        for(int i = 0; i < nums.Length; i++){
            int comp = target - nums[i];

            if(cache.ContainsKey(comp))
                return new int[2] { cache[comp], i };
            
            cache[nums[i]] = i;

        }

        return new int[2];
    }
}
