public class Solution {
    public int[] TopKFrequent(int[] nums, int k){
	var count = new Dictionary<int, int>();  //{ number, count }
	
	foreach(int num in nums)
		count[num] = count.GetValueOrDefault(num, 0) + 1;
	
	var minHeap = new PriorityQueue<int, int>(); //minHeap
	
	foreach(var kvp in count){
	
		minHeap.Enqueue(kvp.Key, kvp.Value);
		
		while(minHeap.Count > k)
			minHeap.Dequeue();
	}
	
	var result = new int[minHeap.Count];
    int index = 0;

    while(minHeap.Count > 0){
        result[index++] = minHeap.Dequeue();
    }

    return result;
}
}
