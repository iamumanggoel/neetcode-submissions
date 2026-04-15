public class Solution {

    public int SingleNumber(int[] nums) {
        var dict = new Dictionary<int, int>();

        foreach(int num in nums)
            dict[num] = dict.GetValueOrDefault(num, 0) + 1;
        
        foreach(var kvp in dict){
            if(kvp.Value == 1)
                return kvp.Key;
        }

        return -1;
    }
}
