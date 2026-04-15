public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //[1, 1, 2, 8]
        //[48, 24, 6, 1]

        var arr = new int[nums.Length];
        arr[0] = arr[nums.Length - 1] = 1;

        //[1,1,2,8]
        for(int i = 1; i < nums.Length; i++){
            arr[i] = arr[i-1] * nums[i-1];
        }

        var suffixProduct = 1;
        for(int i = nums.Length - 1; i >= 0; i--){
            arr[i] = arr[i] * suffixProduct;

            suffixProduct = suffixProduct * nums[i];
        }

        return arr;
    }
}
