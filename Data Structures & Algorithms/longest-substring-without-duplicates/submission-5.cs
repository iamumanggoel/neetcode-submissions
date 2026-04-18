public class Solution {
    public int LengthOfLongestSubstring(string s) {
        if(s.Length <=1) return s.Length;

        int startIdx = 0;
        int maxLen = 0;

        while(startIdx < s.Length){
            var set = new HashSet<int>(); //To track duplicates in current candidate
            int endIdx = startIdx + 1;
            set.Add(s[startIdx]);

            while(endIdx < s.Length && set.Add(s[endIdx])) endIdx++;
                        maxLen = Math.Max(maxLen, endIdx - startIdx);

            startIdx++;
        }


        return maxLen;
    }
}
