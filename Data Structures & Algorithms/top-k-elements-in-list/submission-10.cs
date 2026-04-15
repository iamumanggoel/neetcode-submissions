public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {
        var queue = new PriorityQueue<int, int>();

        var count = new Dictionary<int, int>();
        foreach(int n in nums){
            count[n] = count.GetValueOrDefault(n, 0) +1;
        }

        foreach(var kvp in count){
            queue.Enqueue(kvp.Key, kvp.Value);

            while(queue.Count > k){
                queue.Dequeue();
            }
        }


        int[] res = new int[k];
        int idx = 0;
        while(queue.Count > 0){
            res[idx++] = queue.Dequeue();
        }

        return res;
    }
}
