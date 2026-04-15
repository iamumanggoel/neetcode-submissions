public class Solution {

    //bucketSort
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>();

        foreach(int num in nums)
            count[num] = count.GetValueOrDefault(num, 0) + 1;
            //{num: freq }

        var bucket = new Dictionary<int, List<int>>();

        foreach(var kvp in count){
            if(!bucket.ContainsKey(kvp.Value))
                bucket[kvp.Value] = new List<int>();

            bucket[kvp.Value].Add(kvp.Key);
            //freq: [num in nums]
        }

        var result = new List<int>();
        //occurance/freq of any ele can not be greater than size of array nums
        for(int i = nums.Length; i >= 1; i--){
            if(bucket.ContainsKey(i)){
                result.AddRange(bucket[i]);
            }

            if(result.Count == k)
                return result.ToArray();

            if(result.Count > k){
                return result.GetRange(0, k).ToArray();
            }
        }

        return result.ToArray();
    }
}
