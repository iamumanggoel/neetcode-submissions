public class Solution {

    public int SingleNumber(int[] nums) {
        var res = 0;

        foreach(int num in nums){
            res = res ^ num;   
        }

        return res;
    }
}
