public class Solution {
    public bool IsValid(string s) {
        if(s.Length % 2 != 0)
            return false;

        var st = new Stack<char>();

        foreach(char c in s){
            if(c == '(' || c == '{' || c == '['){
                st.Push(c);
            }
            else{
                if(st.Count == 0) return false;
                char top = st.Pop();

                if(top == '(' && c != ')')
                    return false;
                
                if(top == '{' && c != '}')
                    return false;

                if(top == '[' && c != ']')
                    return false;
                

            }
        }

        return st.Count > 0 ? false: true;
    }
}
