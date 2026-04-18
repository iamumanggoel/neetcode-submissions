public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int m = s1.Length, n = s2.Length;
        
        // Time: O(n*2), Space: O(n)
        for(int i = 0; i < n - m + 1; i++){
            Console.WriteLine($"s1: {s1} \t s2: {s2.Substring(i, m)} ");
            if(IsPermutation(s1, s2.Substring(i, m))) return true;
        }

        return false;
    }

    private bool IsPermutation(string a, string b){
        int m = a.Length, n = b.Length;

        if(m != n) return false;

        var count = new int[26];
        for(int i = 0; i < m; i++){
            count[a[i] - 'a']++;
            count[b[i] - 'a']--;
        } 

        for(int i = 0; i < 26; i++){
            if(count[i] != 0)
                return false;
        }

        return true;
    }
}
