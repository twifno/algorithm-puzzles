//https://leetcode.com/problems/implement-stack-using-queues/

//Two queue (actually can be one queue) approach.

public class MyStack {
    Queue<int> q;
    Queue<int> tmp;

    /** Initialize your data structure here. */
    public MyStack() {
        q = new Queue<int>();
        tmp = new Queue<int>();
    }
    
    /** Push element x onto stack. */
    public void Push(int x) {
        while(q.Count > 0) {
            tmp.Enqueue(q.Dequeue());
        }
        q.Enqueue(x);
        while(tmp.Count > 0){
            q.Enqueue(tmp.Dequeue());
        }
    }
    
    /** Removes the element on top of the stack and returns that element. */
    public int Pop() {
        return q.Dequeue();
    }
    
    /** Get the top element. */
    public int Top() {
        return q.Peek();
    }
    
    /** Returns whether the stack is empty. */
    public bool Empty() {
        return q.Count == 0;
    }
}

/**
 * Your MyStack object will be instantiated and called as such:
 * MyStack obj = new MyStack();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Top();
 * bool param_4 = obj.Empty();
 */
