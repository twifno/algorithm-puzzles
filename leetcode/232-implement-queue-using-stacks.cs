//https://leetcode.com/problems/implement-queue-using-stacks/

public class MyQueue {
    Stack<int> ist;
    Stack<int> ost;

    /** Initialize your data structure here. */
    public MyQueue() {
        ist = new Stack<int>();
        ost = new Stack<int>();
    }
    
    /** Push element x to the back of queue. */
    public void Push(int x) {
        ist.Push(x);
    }
    
    /** Removes the element from in front of queue and returns that element. */
    public int Pop() {
        if(ost.Count > 0) return ost.Pop();
        while(ist.Count > 0) ost.Push(ist.Pop());
        return ost.Pop();
    }
    
    /** Get the front element. */
    public int Peek() {
        if(ost.Count > 0) return ost.Peek();
        while(ist.Count > 0) ost.Push(ist.Pop());
        return ost.Peek();
    }
    
    /** Returns whether the queue is empty. */
    public bool Empty() {
        return ist.Count == 0 && ost.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */
