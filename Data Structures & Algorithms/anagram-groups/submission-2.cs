public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        string FindKey(string s){
            int[] count = new int[26];

            foreach(char c in s)
                count[c - 'a']++;
            
            return string.Join("#", count);
        }

        //Lets store it in a dict with {freqCount: [str in strs] }
        var dict = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            string key = FindKey(strs[i]);

            if(!dict.ContainsKey(key))
                dict[key] = new List<string>();
            
            dict[key].Add(strs[i]);

        } 

        var res = new List<List<string>>();
        foreach(var kvp in dict){
            res.Add(kvp.Value);
        }

        return res;
    }
}
