public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var result =  new Dictionary<string, List<string>>(); //key: ["", ""]
        for(int i = 0; i < strs.Length; i++){
            string key = FindKey(strs[i]);

            if(!result.ContainsKey(key))
                result[key] = new List<string>();

            result[key].Add(strs[i]);
        }

        return result.Values.ToList();

    }

    private string FindKey(string s){
        var count = new int[26];

        foreach(char c in s){
            count[c - 'a']++;
        }

        var sb = new StringBuilder();
        for(int i = 0; i < 26; i++){
            sb.Append(count[i]);
            sb.Append('#');
        }

        return sb.ToString();
    }
}
