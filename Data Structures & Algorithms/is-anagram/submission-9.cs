public class Solution {
    public bool IsAnagram(string s, string t) {
       if(s.Length != t.Length)
            return false;
       
       var freq = new Dictionary<char, int>(); // {[char c in s]: count}

       foreach(char c in s){
        if(freq.ContainsKey(c))
            freq[c]++;
        else{
            freq[c] = 1;
        }
       }


       foreach(char c in t){
        if(!freq.ContainsKey(c))
            return false;
        
        freq[c]--;
       }


       foreach(var kvp in freq){
        if(kvp.Value != 0)
            return false;
       }

       return true;
    }
}
