public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var dict = new Dictionary<int, int>(); //{num: count}
        foreach(int num in nums){
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        }

        return dict
            .OrderByDescending(d => d.Value)
            .Take(k)
            .Select(d => d.Key)
            .ToArray();
    }
}
