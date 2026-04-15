public class Solution {
    public double MyPow(double x, int n) {
        double res = 1;
        int absoluteFactor = n > 0 ? 1: -1;
        int size = absoluteFactor * n;
        for(int i = 1; i <= size; i++){
            
            res = res * (absoluteFactor == 1 ? x: (1/x));
        }

        return res;
        
    }
}
