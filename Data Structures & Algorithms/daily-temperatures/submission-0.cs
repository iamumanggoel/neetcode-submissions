public class Solution {
    public int[] DailyTemperatures(int[] temperatures) {
        int[] res = new int[temperatures.Length];

        for(int i = 0; i < temperatures.Length - 1; i++){
            for(int j = i+1; j < temperatures.Length; j++){
                
                if(temperatures[i] < temperatures[j]){
                    res[i] = j - i;
                    break;
                }
                
            }
        }

        return res;
    }
}
