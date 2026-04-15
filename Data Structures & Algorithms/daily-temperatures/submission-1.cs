public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];

        var stack = new Stack<(int temp, int index)>();

        for(int i = 0; i < temperatures.Length; i++){
            int t= temperatures[i];

            while(stack.Count > 0 && stack.Peek().temp < t){
                var pop = stack.Pop();
                res[pop.index] = i - pop.index;
            } 

            stack.Push((t, i));

        }
        return res;

    }
}
