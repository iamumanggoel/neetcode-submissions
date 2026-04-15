public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var pq = new PriorityQueue<int, int>(); // elemenent, count

        var freqMap = new Dictionary<int, int>(); // {num, count}

        foreach(int num in nums) //O(n)
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;

        foreach(var (key, value) in freqMap){
            pq.Enqueue(key, value);

            if(pq.Count > k)
                pq.Dequeue();
        }

        var result = new int[pq.Count];

        for(int i = 0; i < result.Length; i++){
            result[i] = pq.Dequeue();
        }

        return result;
        
    }
}
