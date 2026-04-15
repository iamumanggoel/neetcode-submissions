public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, List<string>>(); //{key: [act]}

        foreach(string s in strs){
            string key = FindKey(s);

            if(!dict.ContainsKey(key))
                dict[key] = new List<string>();
            dict[key].Add(s);
        }

        return dict.Values.ToList<List<string>>();
    }

    private string FindKey(string s){
        // var sb = new StringBuilder();

        int[] count = new int[26];

        for(int i = 0; i < s.Length; i++){
            count[s[i] - 'a']++;
        }

        return string.Join(",", count);
    }
}
