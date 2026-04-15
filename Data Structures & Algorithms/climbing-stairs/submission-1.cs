public class Solution {

    private Dictionary<int, int> map = new Dictionary<int, int>();
    public int ClimbStairs(int n) { 
           
        if(n <= 2)
            return n;
        
        if(map.ContainsKey(n))
            return map[n];

        map[n] = ClimbStairs(n-1) + ClimbStairs(n-2);
        
        return map[n];
    }
}

// 1 + 