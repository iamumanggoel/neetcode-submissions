public class Solution {
    public int LongestConsecutive(int[] nums) {
        if(nums.Length <= 1) return nums.Length;

        var maxL = 0;

        var unique = new HashSet<int>(nums);

        foreach(int num in unique){
            if(unique.Contains(num - 1))
                continue;

            //this is first ele of sequence
            int currL = 1, currNum = num;
            while(unique.Contains(currNum)){
                currNum++;
                currL++;
            }

            maxL = Math.Max(maxL, currL-1);
        }

        return maxL;


    }
}
