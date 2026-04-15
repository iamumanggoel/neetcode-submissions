public class Solution {
    public int Reverse(int x) {
        int result = 0;

        while(x != 0){

            int unit = x % 10;
            if(result > (int.MaxValue/10 - unit) || result < (int.MinValue/10 - unit))
                return 0;
            result = result * 10 + unit;
            x /= 10;
        }

        return result;
    }
}
