public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var seen = new Dictionary<int, int>(); //{ num: idx }

        for(int i = 0; i < nums.Length; i++){

            int comp = target - nums[i];

            if(seen.ContainsKey(comp))
                return new int[2] { seen[comp], i };

            seen[nums[i]] = i;
        }

        return new int[0];
    }
}
