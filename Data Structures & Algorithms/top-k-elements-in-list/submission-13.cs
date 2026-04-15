public class Solution {
    public int[] TopKFrequent(int[] nums, int k) {

        if(nums.Length < k) return nums;

        var freqMap = new Dictionary<int, int>(); // num: count

        foreach(int num in nums){
            freqMap[num] = freqMap.GetValueOrDefault(num, 0) + 1;
        }

        var qp = new PriorityQueue<int, int>();

        foreach(var kvp in freqMap){
            qp.Enqueue(kvp.Key, kvp.Value);
            if(qp.Count > k){
                qp.Dequeue();
            }
        }

        int[] res = new int[k];

        for(int i = 0; i < k; i++){
            if(qp.Count == 0) return nums;

            res[i] = qp.Dequeue();
        }

        return res;



        // while(qp.Count > 0){
        //     var kvp = qp.Dequeue();
        //     Console.WriteLine($"{kvp}");
        // }


        // return new int[0];


    }
}
