public class MinStack {

    private Stack<int> stk;
    private Stack<int> minStk;
    public MinStack() {
        stk = new Stack<int>();
        minStk = new Stack<int>();
    }
    
    public void Push(int val) {
        if(minStk.Count == 0 || minStk.Peek() >= val) minStk.Push(val);
        stk.Push(val);
    }
    
    public void Pop() {
        if(minStk.Count != 0 && stk.Peek() <= minStk.Peek()) minStk.Pop();
        stk.Pop();
    }
    
    public int Top() {
        return stk.Count > 0 ? stk.Peek(): -1;
    }
    
    public int GetMin() {
        return minStk.Count > 0 ? minStk.Peek(): -1;
    }
}
