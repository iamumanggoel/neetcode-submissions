public class Solution {
    public List<List<int>> ThreeSum(int[] nums) {
        Array.Sort(nums); //O(nlogn)

        int i = 0;
        int n = nums.Length;
        var result = new List<List<int>>();
        while(i < n-2){
            
            if(i > 0 && nums[i] == nums[i-1]){
                i++;
                continue;
            }

            int j = i + 1, k = n - 1;

            while(j < k){
                int sum = nums[i] + nums[j] + nums[k];

                if(sum > 0) k--;
                else if(sum < 0) j++;
                else{
                    result.Add(new List<int> { nums[i], nums[j], nums[k] });
                    j++;
                    k--;
                    while(j < k && nums[j] == nums[j-1]) j++;

                    while(j < k && nums[k] == nums[k+1]) k--;
                }
            }



            i++;
        }


        return result;
    }
}
