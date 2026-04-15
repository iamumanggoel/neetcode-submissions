public class Solution {

    public string Encode(IList<string> strs) {

        if(strs.Count == 0)
            return string.Empty;
            
        var sb = new StringBuilder();

        foreach(var str in strs)
            sb.Append($"{str.Length}#{str}");

        return sb.ToString();
    }

    //4#neet
    public List<string> Decode(string s) {

        var result = new List<string>();

        if(string.IsNullOrEmpty(s))
            return result;

        int i = 0;
        while(i < s.Length){
            var lensb = new StringBuilder();

            while(i < s.Length && s[i] != '#'){
                lensb.Append(s[i]);
                i++;
            }
            
            //skip `Pound`
            i = i + 1;

            int len = int.Parse(lensb.ToString());
            
            result.Add(s.Substring(i, len));

            i = i + len;

        }

        return result;
   }
}
