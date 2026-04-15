public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var count = new Dictionary<int, int>(); // { ele: freqOfEachChar }

        foreach(int num in nums)
            count[num] = count.GetValueOrDefault(num, 0) + 1;

        var bucket = new List<int>[nums.Length + 1];

        foreach(var (key, value) in count){
            if(bucket[value] is null)
                bucket[value] = new List<int>();
            bucket[value].Add(key); 

        }

        var result = new int[k];
        int index = 0;

        for(int i = bucket.Length -1 ; i > 0 && index < k; i--){
            if(bucket[i] != null){
                foreach(int listVal in bucket[i]){
                    result[index++] = listVal;

                    if(index == k)
                        return result;
                }

            }
        }

        return result;


    }
}
