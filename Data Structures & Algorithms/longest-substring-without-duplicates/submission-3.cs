public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <= 1) 
            return s.Length;


        var seen = new HashSet<char>();
        int i = 0, j = i + 1, result = 0;
        seen.Add(s[i]);

        while(j < s.Length){
            if(!seen.Contains(s[j])){
                seen.Add(s[j]);
                j++;
                result = Math.Max(result, j - i);
            }
            else{
                seen.Remove(s[i]);
                i++;
            }
        }

        return result;
    }
}
