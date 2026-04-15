public class Solution {
    public bool IsHappy(int n) {
        var seen = new HashSet<int>();
        seen.Add(n);

        int curr = n;
        while(true){
            curr = SumOfSquares(curr);

            if(curr == 1)
                return true;

            if(!seen.Add(curr))
                return false;
        }

        return false;
    }

    private int SumOfSquares(int n){
        int res = 0;
        while(n != 0){
            int rem = n % 10;
            res = res + rem*rem;
            n /= 10;
        }
        return res;
    }
}
