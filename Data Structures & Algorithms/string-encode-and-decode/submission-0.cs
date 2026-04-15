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

    // 23#Hdsfnnsdjf
    public List<string> Decode(string s) {
        var result = new List<string>(); 
        int i = 0;
        while(i < s.Length){
            int j = i;
            while(j < s.Length && char.IsDigit(s[j]))
                j++;

            if(s[j] == '#'){
                int len = int.Parse(s.Substring(i, j - i));
                j++;
                result.Add(s.Substring(j, len));
                i = j + len;
            }
            
        }   

        return result;
   }
}
