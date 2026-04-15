public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();

        foreach(string s in strs){
            sb.Append(s.Length);
            sb.Append('#');
            sb.Append(s);
        }

        return sb.ToString();
    }

    //4#neet4#code4#love3#you
    public List<string> Decode(string s) {
        if(string.IsNullOrEmpty(s))
            return new List<string>();
        
        var result = new List<string>();
        
        int i = 0;
        while(i < s.Length){

            int j = i;
            while(s[j] != '#')
                j++;
            
            int.TryParse(s.Substring(i, j - i), out int len);

            i = j + 1;
            result.Add(s.Substring(i, len));

            i = i + len;
            
        }

        return result;
   }
}
