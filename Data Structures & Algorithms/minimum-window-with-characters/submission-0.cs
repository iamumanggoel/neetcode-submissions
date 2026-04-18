public class Solution {
    public string MinWindow(string s, string t) {
        if (s.Length == 0 || t.Length == 0) return "";

        var need = new int[128];
        foreach (char c in t) {
            need[c]++;
        }

        int required = t.Length;
        int left = 0, minLen = int.MaxValue, start = 0;

        for (int right = 0; right < s.Length; right++) {
            if (need[s[right]] > 0) {
                required--;
            }
            need[s[right]]--;

            // When valid window
            while (required == 0) {
                if (right - left + 1 < minLen) {
                    minLen = right - left + 1;
                    start = left;
                }

                need[s[left]]++;
                if (need[s[left]] > 0) {
                    required++;
                }
                left++;
            }
        }

        return minLen == int.MaxValue ? "" : s.Substring(start, minLen);
    }
}