public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {

        int i = 0, j = k;
        var result = new List<int>();
        int idx = 0;
        while(j <= nums.Length){
            result.Add(FindMax(i++, j++, nums));
        }

        return result.ToArray();
    }

    private int FindMax(int left , int right, int[] arr){
        int max = int.MinValue;
        for(int i = left; i < right; i++){
            max = Math.Max(max, arr[i]);
        }

        return max;
    }
}
