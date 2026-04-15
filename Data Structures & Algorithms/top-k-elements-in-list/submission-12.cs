public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var freqMap = new Dictionary<int, int>();

        foreach(int num in nums)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;

        
        var heap = new PriorityQueue<int, int>(); //val: priority

        foreach(var kvp in freqMap){

            heap.Enqueue(kvp.Key, kvp.Value);

            while(heap.Count > k)
                heap.Dequeue();
        }


        int[] res = new int[k];
        int idx = 0;

        while(heap.Count > 0){

            int ele = heap.Dequeue();
            res[idx++] = ele;
        }

        return res;
    }
}
