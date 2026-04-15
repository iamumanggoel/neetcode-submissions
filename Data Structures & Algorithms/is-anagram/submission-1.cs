public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length)
            return false;
        
        var arr = new int[26];


        foreach(char c in s){
            arr[c - 'a'] += 1; 
        }

        foreach(char c in t){
            arr[c - 'a'] -= 1;
        }

        for(int i = 0; i < 26; i++){
            if(arr[i] != 0)
                return false;
        }

        return true;
        
    }
}
