public class Solution {
    public int CharacterReplacement(string s, int k) {
        int i = 0, j = 0, n = s.Length, res = 0, currMaxFreq = 0;
        var countMap = new int[26];

        while(j < n){
            countMap[s[j] - 'A']++;
            currMaxFreq = Math.Max(currMaxFreq, countMap[s[j] - 'A']);

            while((j - i + 1 - currMaxFreq) > k){
                countMap[s[i] - 'A' ]--;
                i++;
            }

            res = Math.Max(res, j - i + 1);

            j++;
        }


        return res;
    }
}
