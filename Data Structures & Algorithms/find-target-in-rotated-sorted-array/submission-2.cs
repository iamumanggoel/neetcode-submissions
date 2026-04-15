public class Solution {
    public int Search(int[] nums, int target) {
        //there are two sorted halves
        //[3,4,5,6], [1,2]

        int l = 0, r = nums.Length - 1;

        while(l <= r){
            int mid = l + (r-l)/2;

            if(nums[mid] == target)
                return mid;
            
            if(nums[l] <= nums[mid]){
                //left half

                if(nums[l] > target || nums[mid] < target){
                    l = mid + 1;
                }
                else{
                    r = mid - 1;
                }
            }
            else{
                //right half
                if(nums[r] < target || nums[mid] > target){
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
