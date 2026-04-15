public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>(); //num: index

        foreach(int num in nums)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        
        var bucketList = new List<List<int>>(nums.Length + 1);
        for(int i = 0; i <= nums.Length; i++)
            bucketList.Add(new List<int>());

        foreach(var kvp in freqMap){
            bucketList[kvp.Value].Add(kvp.Key);

        }
        var result = new List<int>(); 

        for(int i = bucketList.Count -1 ; i >= 0; i--){
            foreach(var ele in bucketList[i]){
                if(k > 0){
                    result.Add(ele);
                    k--;
                }
                
                if(k == 0)
                    return result.ToArray();
            }
        }
        
        return result.ToArray();
    }
}
