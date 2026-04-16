public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //Input: [1,2,4,6]

        //productOfRight start loop from End
        //productOfLeft
        //productOfRight * productOfLeft

        // [2*4*6, 4*6, 6, 1]
        // [1, 1, 1*2, 1*2*4]
        // [48, 24, 12, 8]

        var len = nums.Length;

        var productOfLefts = new int[len];
        var productOfRights = new int[len];

        productOfLefts[0] = 1;
        for(int i = 1; i < len; i++) 
            productOfLefts[i] = productOfLefts[i-1] * nums[i-1];

        productOfRights[len - 1] = 1;
        for(int i = len - 2; i >= 0; i--){
            productOfRights[i] = productOfRights[i+1] * nums[i+1];
        }
        
        var result = new int[len];
        for(int i = 0; i < len; i++){
            result[i] = productOfLefts[i] * productOfRights[i];
        }

        return result;
    }
}
