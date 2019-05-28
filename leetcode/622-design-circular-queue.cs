//https://leetcode.com/problems/design-circular-queue/

public class MyCircularQueue {
    int Count;
    int Head;
    int Tail;
    int[] Q;
    int K;

    /** Initialize your data structure here. Set the size of the queue to be k. */
    public MyCircularQueue(int k) {
        K = k;
        Count= 0;
        Head = 0;
        Tail = 0;
        Q = new int[k];
    }
    
    /** Insert an element into the circular queue. Return true if the operation is successful. */
    public bool EnQueue(int value) {
        if(Count == K) return false;
        Q[Tail] = value;
        Count += 1;
        Tail = (Tail + 1) % K;
        return true;
    }
    
    /** Delete an element from the circular queue. Return true if the operation is successful. */
    public bool DeQueue() {
        if(Count == 0) return false;
        Head = (Head + 1) % K;
        Count -= 1;
        return true;
    }
    
    /** Get the front item from the queue. */
    public int Front() {
        if(Count == 0) return -1;
        return Q[Head];
    }
    
    /** Get the last item from the queue. */
    public int Rear() {
        if(Count == 0) return -1;
        if(Tail == 0) return Q[K-1];
        return Q[Tail-1];
    }
    
    /** Checks whether the circular queue is empty or not. */
    public bool IsEmpty() {
        return Count == 0;
    }
    
    /** Checks whether the circular queue is full or not. */
    public bool IsFull() {
        return Count == K;
    }
}

/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue obj = new MyCircularQueue(k);
 * bool param_1 = obj.EnQueue(value);
 * bool param_2 = obj.DeQueue();
 * int param_3 = obj.Front();
 * int param_4 = obj.Rear();
 * bool param_5 = obj.IsEmpty();
 * bool param_6 = obj.IsFull();
 */
