public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        var seen = new Dictionary<int, int>();

        for(int i = 0; i < numbers.Length; i++){
            int comp = target - numbers[i];

            if(seen.ContainsKey(comp))
                return new int[2] { seen[comp] + 1, i + 1 };
            
            seen[numbers[i]] = i;
        }

        return new int[0];
    }
}
