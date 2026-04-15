public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(string s in strs){
            sb.Append(s.Length);
            sb.Append("#");
            sb.Append(s);
        }

        return sb.ToString();
    }

    //41#neet4#code4#love3#you
    public List<string> Decode(string s) {
        
        var result = new List<string>();

        if(s.Length < 2)
            return result;

        int i = 0;

        while(i < s.Length){

            int j = i;
            while(char.IsDigit(s[j])){
                j++;
            }
            
            int.TryParse(s.Substring(i, (j-1)-i+1), out var len);

            //skip `#`
            i = j + 1;
            result.Add(s.Substring(i, len));

            i = i + len;
        }

        return result;

   }
}
