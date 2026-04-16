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

        productOfLefts[0] = 1;
        for(int i = 1; i < len; i++) 
            productOfLefts[i] = productOfLefts[i-1] * nums[i-1];

        var productOfRights = 1;
        for(int i = len - 2; i >= 0; i--){
            productOfRights = productOfRights * nums[i+1];
            productOfLefts[i] *= productOfRights;
        }
        
        return productOfLefts;
    }
}
