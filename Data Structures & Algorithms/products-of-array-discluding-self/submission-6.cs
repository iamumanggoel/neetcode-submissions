public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        //[1, 1, 1*2, 1*2*4]
        //[2*4*6 , 4*6 ,6, 1]

        int[] prefix = new int[nums.Length];
        // int[] postfix = new int[nums.Length];

        prefix[0] = 1;
        for(int i = 1; i < nums.Length; i++){
            prefix[i] = prefix[i - 1] * nums[i-1];
        }

        int postfix = 1;
        for(int i = nums.Length - 2; i >= 0; i--){
            postfix = postfix * nums[i+1];
            prefix[i] = prefix[i] * postfix;
        }

        // var result = new int[nums.Length];

        // Console.WriteLine($"prefix:{string.Join(',', prefix)} \n postfx: {string.Join(',', postfix)}");
        // for(int i = 0; i < nums.Length; i++){
        //     result[i] = prefix[i] * postfix[i];
        // }

        return prefix;
    }
}
