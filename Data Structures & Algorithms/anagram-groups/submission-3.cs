public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {

        var dict = new Dictionary<string, List<string>>(); //{ key: [anagramic Strings]}
        foreach(string str in strs){
            string key = FindKey(str);

            if(!dict.ContainsKey(key))
                dict[key] = new List<string>();
            
            dict[key].Add(str);
        }

        return dict.Values.ToList();

    }

    private string FindKey(string s){
        var count = new int[26];

        foreach(char c in s){
            count[c - 'a']++;
        }

        return string.Join("#", count);
    }
}
