//https://leetcode.com/problems/max-stack/

//Two Stacks Implementation.

public class MaxStack {
    Stack<int> Maxs;
    Stack<int> St;

    /** initialize your data structure here. */
    public MaxStack() {
        Maxs = new Stack<int>();
        St = new Stack<int>();
    }
    
    public void Push(int x) {
        St.Push(x);
        if(Maxs.Count == 0 || Maxs.Peek() <= x) Maxs.Push(x);
    }
    
    public int Pop() {
        if(St.Count == 0) return -1;
        int x = St.Pop();
        if(Maxs.Count > 0 && Maxs.Peek() == x) Maxs.Pop();
        return x;
    }
    
    public int Top() {
        if(St.Count == 0) return -1;
        return St.Peek();
    }
    
    public int PeekMax() {
        if(St.Count == 0) return -1;
        return Maxs.Peek();
    }
    
    public int PopMax() {
        if(St.Count == 0) return -1;
        Stack<int> tmp = new Stack<int>();
        while(St.Peek() != Maxs.Peek()) tmp.Push(Pop());
        int ret = Pop();
        while(tmp.Count > 0) Push(tmp.Pop());
        return ret;
    }
}

/**
 * Your MaxStack object will be instantiated and called as such:
 * MaxStack obj = new MaxStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.PeekMax();
 * int param_5 = obj.PopMax();
 */
