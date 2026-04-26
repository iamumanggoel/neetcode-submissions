public class Solution {
    public int EvalRPN(string[] tokens) {
        var stk = new Stack<int>();

        foreach(string token in tokens){
            if(isDigit(token)){
                int.TryParse(token, out int t);
                stk.Push(t);
                continue;
            }

            if(stk.Count < 2)
                return int.MinValue;

            int right = stk.Pop();
            int left = stk.Pop();

            int res = token switch {
                 "+" =>  left + right,
                 "-" =>  left - right,
                 "*" =>  left * right,
                 "/" =>  left / right,
                 _ =>  0
            };

            stk.Push(res);
        }


        return stk.Count > 0 ? stk.Pop(): int.MinValue;
        
    }

    private bool isDigit(string t){
        if(t == "+" || t == "-" || t == "/" || t == "*")
            return false;
            
        return true;
    }
}
