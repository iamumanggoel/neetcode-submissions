public class Solution {

    public string Encode(IList<string> strs) {
        var sb = new StringBuilder();
        foreach(var str in strs) sb.Append($"{str.Length}#{str}");
        return sb.ToString();
    }

    public List<string> Decode(string s) {
        var res = new List<string>();

        for(int i = 0; i < s.Length; i++){

            int j = i;
            while(j < s.Length && char.IsDigit(s[j])) j++;
            int.TryParse(s.Substring(i, j - i), out int len);

            // `#` is skipped
            i = j + 1;
            res.Add(s.Substring(i, len));

            i = i + len - 1;

        }

        return res;
   }
}
