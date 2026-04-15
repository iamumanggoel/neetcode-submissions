public class MinStack {

    private Stack<(int val, int min)> stk;
    
    public MinStack() {
        stk = new Stack<(int val, int min)>();
    }
    
    public void Push(int val) {
        int min = stk.Count == 0 ? val : Math.Min(stk.Peek().min, val);
        stk.Push((val, min));
    }
    
    public void Pop() {
        stk.Pop();
    }
    
    public int Top() {
        return stk.Count == 0 ? throw new Exception("Stack is Empty") : stk.Peek().val;
    }
    
    public int GetMin() {
        return stk.Count == 0 ? throw new Exception("Stack is Empty"): stk.Peek().min;
    }
}
