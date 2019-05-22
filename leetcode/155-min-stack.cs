//https://leetcode.com/problems/min-stack/

//Handle by double stacks

public class MinStack {
    Stack<int> St = new Stack<int>();
    Stack<int> StMin = new Stack<int>();
    
    
    /** initialize your data structure here. */
    public MinStack() {
        
    }
    
    public void Push(int x) {
        St.Push(x);
        if(StMin.Count == 0 || StMin.Peek() >= x) StMin.Push(x);
    }
    
    public void Pop() {
        int n = St.Pop();
        if(n == StMin.Peek()) StMin.Pop();
    }
    
    public int Top() {
        return St.Peek();
    }
    
    public int GetMin() {
        return StMin.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(x);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
