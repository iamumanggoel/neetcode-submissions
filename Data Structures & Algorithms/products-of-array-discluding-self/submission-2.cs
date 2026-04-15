public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int n = nums.Length;

        var prefixProds = new int[n];

        //[1, 1, 2, 8]
        prefixProds[0] = 1;
        for(int i = 1; i < n; i++){
            prefixProds[i] = nums[i-1] * prefixProds[i-1];
        }

        var suffixProds = new int[n];
        suffixProds[n - 1] = 1;

        for(int i = n - 2; i >= 0; i--){
            suffixProds[i] = nums[i+1] * suffixProds[i+1];
        }

        var result = new int[n];
        for(int i = 0; i < n; i++)
            result[i] = prefixProds[i]*suffixProds[i];

        return result;
    }
}
