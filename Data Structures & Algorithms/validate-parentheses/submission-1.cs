public class Solution {

    private static Dictionary<char, char> dict = new Dictionary<char, char>{
        {
            '[', ']'
        },
        
        {
            '(', ')'
        },
        {
            '{', '}'
        }
    };

    public bool IsValid(string s) {
        int n = s.Length;

        if(n == 0)
            return true;
        
        if(n % 2 != 0)
            return false;

        var stk = new Stack<char>();

        for(int i = 0; i < n; i++){

            //Open bracket to be pushed on stack
            if(dict.ContainsKey(s[i])){
                stk.Push(s[i]);
                continue;
            }
            
            //if stk is still empty, its not valid
            if(stk.Count == 0) return false;

            //if pair is not found, invalid parantheses
            if(dict[stk.Peek()] != s[i]) return false;

            //if pair is found, pop stack top
            stk.Pop();
            
            
            
        }

        
        return stk.Count() == 0;
    }
}
