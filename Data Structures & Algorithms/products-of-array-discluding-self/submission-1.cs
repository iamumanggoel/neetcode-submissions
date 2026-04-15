public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length, zeroCount = 0;
        
        int prod = 1;
        foreach(int num in nums){
            if(num == 0){
                zeroCount++;
            }
            else{
                prod = prod * num;
            }    
        }

        int[] result = new int[n];
        if(zeroCount > 1)
            return result;


        for(int i = 0; i < n; i++){
            if(nums[i] == 0){
                result[i] = prod;
            }
            else{
                result[i] = (zeroCount == 0) ? prod/nums[i]: 0; 
            } 
        }

        return result;


    }
}
