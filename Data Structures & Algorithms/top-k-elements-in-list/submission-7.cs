public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>(); //num: count

        foreach(int num in nums)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        
        var minHeap = new PriorityQueue<int, int>(); //ele; priority

        foreach(var kvp in freqMap){
            minHeap.Enqueue(kvp.Key, kvp.Value);

            if(minHeap.Count > k)
                minHeap.Dequeue();
        }

        int[] res = new int[k];
        int index = 0;
        while(minHeap.Count > 0){
            res[index++] = minHeap.Dequeue();
        }

        return res;
    }
}
