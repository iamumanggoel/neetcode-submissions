public class Solution {
    public int Search(int[] nums, int target) {
        //Step 1: divide into two halves target: 1
        //sorted1: [3,4,5,6]; sorted2: [1,2]

        //Step2: is target in sorted1 or sorted2?

        //Step3: return the first ele of correct sortedarr

        int n = nums.Length;
        int l = 0, r = n - 1;

        while(l <= r){
            int mid = l + (r - l)/2;

            if(nums[mid] == target)
                return mid;
            
            if(nums[l] <= nums[mid]){
                //its in left half i.e l to mid
                if(target < nums[l] || target > nums[mid]){
                    l = mid + 1;
                }
                else{
                    r = mid - 1;
                }
            }
            else
            {
                
                //its in right half i.e mid to r
                if(target < nums[mid] || target > nums[r])
                {
                    r = mid - 1;
                }
                else{
                    l = mid + 1;
                }
                
            }
        }

        return -1;
    }
}
