public class Solution {
    public int CharacterReplacement(string s, int k) {
        var freqMap = new Dictionary<char, int>();
        int i = 0, j = 0, maxFreq = 0, result = 0;

        while(j < s.Length){
            freqMap[s[j]] = freqMap.GetValueOrDefault(s[j], 0) + 1;

            maxFreq = Math.Max(maxFreq, freqMap[s[j]]);

            //Needed more replaecments than `k`
            if(j-i+1 - maxFreq > k){
                freqMap[s[i]]--;
                i++;
            }

            result = Math.Max(result, j - i + 1);

            j++;
        }


        return result;


    }
}
