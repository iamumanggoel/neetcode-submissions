public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        int m = s1.Length, n = s2.Length;
        var count = new int[26];
        var windowCount = new int[26];
        if(m > n) return false;

        for(int i = 0; i < m; i++){
            count[s1[i] - 'a']++;
            windowCount[s2[i] - 'a']++;
        }

        if(IsCharCountSame(count, windowCount)) return true;

        for(int i = m; i < n; i++){
            windowCount[s2[i] - 'a']++;
            windowCount[s2[i - m] - 'a']--;
            if(IsCharCountSame(count, windowCount)) return true;
        }


        return false;
    }

    private bool IsCharCountSame(int[] a, int[] b){
        for(int i = 0; i < 26; i++)
            if(a[i] != b[i]) return false;
        
        return true;
    }
}
