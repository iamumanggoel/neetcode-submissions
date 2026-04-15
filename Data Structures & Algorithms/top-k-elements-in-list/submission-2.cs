public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>(); //{num: freq}
        foreach(int num in nums)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;

        var bucket = new Dictionary<int, List<int>>(); //{freq: [num1, num2]}
        foreach(var (key, value) in freqMap){
            if(!bucket.ContainsKey(value)){
                bucket[value] = new List<int>();
            }

            bucket[value].Add(key);
        }


        //As the max freq CAN only be limted to the size of array, we will
        //go from the very right
        var result = new List<int>(); 
        for(int i = nums.Length; i >= 1; i--){
            if(bucket.ContainsKey(i))
                result.AddRange(bucket[i]);
            
            if(result.Count == k)
                return result.ToArray();
            
            if(result.Count > k)
                return result.GetRange(0,k).ToArray();
        }

        return result.ToArray();
    }
}
