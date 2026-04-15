public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1) return s.Length;

        int result = 0, i = 0, j = 0;
        var seen = new HashSet<char>();
        
        while(j < s.Length){
            while(seen.Contains(s[j])){
                seen.Remove(s[i]);
                i++;
            }
            seen.Add(s[j]);
            //`-1` because `j` is one step ahead
            result = Math.Max(result, j - i + 1); 
            j++;
        }

        return result;
    }
}
