public class Solution {
    public bool IsAnagram(string s, string t) {
        int m = s.Length, n = t.Length;

        if(m != n)
            return false;


        int[] count = new int[26];

        for(int i = 0; i < m; i++){
            count[s[i] - 'a']++;
            count[t[i] - 'a']--;
        }

        for(int i = 0; i < 26; i++){
            if(count[i] != 0)
                return false;
        }

        return true;

    }
}
