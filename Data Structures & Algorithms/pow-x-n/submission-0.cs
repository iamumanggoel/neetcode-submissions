public class Solution {
    public double MyPow(double x, int n) {
        double res = 1;
        int IsPositive = n > 0 ? 1: -1;
        int size = IsPositive * n;
        for(int i = 1; i <= size; i++){
            
            res = res * (IsPositive == 1 ? x: (1/x));
        }

        return res;
        
    }
}
