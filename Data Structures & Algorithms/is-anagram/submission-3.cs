public class Solution {
    public bool IsAnagram(string s, string t) {
       
        if(s.Length != t.Length) return false;

        int[] s_count = new int[26];
        int[] t_count = new int[26];

        for(int i = 0; i < s.Length; i++){
            s_count[s[i] - 'a']++;
            t_count[t[i] - 'a']++;
        }

        var s_str = string.Join("",s_count);
        var t_str = string.Join("", t_count);

        return s_str == t_str;
        
    }
}
