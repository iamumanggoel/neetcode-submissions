public class Solution {
    public bool IsAnagram(string s, string t) {
       if( s.Length != t.Length)
            return false;

        var alp = new char[26];


        for(int i = 0; i < s.Length; i++){
            alp[s[i] - 'a']++;
            alp[t[i] - 'a']--;
        }

        for(int i = 0; i < 26; i++){
            if(alp[i] != 0)
                return false;
        }

        return true;

        
    }
}
