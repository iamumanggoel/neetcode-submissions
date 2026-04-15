public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>(); //{ key, List<str>}
        foreach(string str in strs){

            var arr = new int[26];
            var sb = new StringBuilder();
            string key;
            foreach(char c in str){
                arr[c - 'a'] += 1;
            }

            for(int i = 0; i < 26; i++){
                sb.Append(arr[i] + "#");
            }

            key = sb.ToString();
            if(!dict.ContainsKey(key))
                dict[key] = new List<string>();

            dict[key].Add(str);
        }

        return dict.Values.ToList();
        
    }
}
