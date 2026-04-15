public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>(); //num: index

        foreach(int num in nums)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        
        return freqMap.OrderByDescending(x => x.Value).Select(x => x.Key).Take(k).ToArray();
    }
}
