public class Solution {
    public bool CheckInclusion(string s1, string s2) {
        if(s1.Length > s2.Length)
            return false;

        int i = 0; //s2.Length - s1.Length

        while(i < s2.Length - s1.Length + 1){
            if(IsPermutation(s1, s2.Substring(i, s1.Length)))
                return true;
            
            i++;
        }

        return false;
    }

    //O(max(Len(a), Len(b)))
    private bool IsPermutation(string a, string b){
        int[] count = new int[26];

        foreach(char c in b){
            count[c - 'a']++;
        }

        foreach(char c in a){
            count[c - 'a']--;
        }

        //Always 26 so fine
        foreach(int c in count){
            if(c != 0)
                return false;
        }

        return true;
    }
}
