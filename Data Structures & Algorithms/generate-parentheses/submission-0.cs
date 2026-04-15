public class Solution {  
    public List<string> GenerateParenthesis(int n) {
        var result = new List<string>();

        dfs("", 0, 0, result, n);

        return result;
    }

    private void dfs(string curr, int open, int close, List<string> res, int n){

        if(open == n && open == close && curr.Length == 2*n){
            res.Add(curr);
            return;
        }

        if(open < n){
            dfs(curr + "(", open + 1, close, res, n);
        }

        if(close < open){
            dfs(curr + ")", open, close+1, res, n);
        }
    }
}
