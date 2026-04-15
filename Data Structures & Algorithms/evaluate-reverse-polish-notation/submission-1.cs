public class Solution {
    public int EvalRPN(string[] tokens) {
        var stk = new Stack<int>();
        int res;

        foreach(string token in tokens){
            if(token is "+" or "-" or "*" or "/"){
                int right = stk.Pop();
                int left = stk.Pop();

                int result = token switch {
                    "+" => left + right,
                    "-" => left - right,
                    "*" => left * right,
                    "/" => left / right,
                    _ => 0
                };
                stk.Push(result);

            }
            else{
                int.TryParse(token, out var num);
                stk.Push(num);
            }
        }

        return stk.Peek();
    }
}
