public class Solution {
    public List<List<string>> GroupAnagrams(string[] strs) {
        var anagramGroups = new Dictionary<string, List<string>>(); //{key: []}
        
        // O(n)
        for(int i = 0; i < strs.Length; i++){
            string candidate = strs[i];
            string key = FindKey(candidate);

            if(!anagramGroups.ContainsKey(key))
                anagramGroups[key] = new List<string>();

            anagramGroups[key].Add(candidate);

        }      

        return anagramGroups.Values.ToList<List<string>>();  
    }



    //O(1) space & time complexity
    private string FindKey(string s){

        int[] count = new int[26];

        foreach(char c in s)
            count[c - 'a']++;

        return string.Join(",", count);
    }
}
