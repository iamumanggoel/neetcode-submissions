public class Solution {
    public bool IsAnagram(string s, string t) {
       
        var s_arr = s.ToCharArray();
        var t_arr = t.ToCharArray();

        Array.Sort(s_arr);
        Array.Sort(t_arr);

        var s_str = string.Join("", s_arr);
        var t_str = string.Join("", t_arr);

        return s_str == t_str;
    }
}
