public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var seen = new Dictionary<string, List<string>>();

        for(int i = 0; i < strs.Length; i++){
            string iKey = FindKey(strs[i]);

            if(!seen.ContainsKey(iKey))
                seen[iKey] = new List<string>();

            seen[iKey].Add(strs[i]);
        }

        return seen.Values.ToList<List<string>>();
    }

    private string FindKey(string s){
        int[] count = new int[26];

        foreach(char c in s){
            count[c - 'a']++; 
        }

        return string.Join("#", count);
    }
}
