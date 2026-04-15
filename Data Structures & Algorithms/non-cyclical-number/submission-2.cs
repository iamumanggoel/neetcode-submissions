public class Solution {
    public bool IsHappy(int n) {
        if(n == 1)
            return true;

        var seen = new HashSet<int>();
        // seen.Add(n);
        while(seen.Add(n)){

            n = SumOfSquares(n);

            if(n == 1)
                return true;
        }

        return false;
    }

    private int SumOfSquares(int n){
        int res = 0;
        while(n != 0){
            int rem = n % 10;
            res += rem*rem;
            n /= 10;
        }

        return res;
    }
}
