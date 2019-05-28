//https://leetcode.com/problems/design-circular-deque/

//Double Linked List.

public class MyCircularDeque {
    
    class Node {
        public Node Prev;
        public Node Next;
        public int Val;
        public Node(int v) {
            Val = v;
        }
    }
    
    Node Head;
    Node Tail;
    int Count;
    int K;

    /** Initialize your data structure here. Set the size of the deque to be k. */
    public MyCircularDeque(int k) {
        Count = 0;
        Head = null;
        Tail = null;
        K = k;
    }
    
    /** Adds an item at the front of Deque. Return true if the operation is successful. */
    public bool InsertFront(int value) {
        if(K == Count) return false;
        if(Head == null){
            Node node = new Node(value);
            Head = node;
            Tail = node;
            Count += 1;
        } else {
            Node node = new Node(value);
            Head.Prev = node;
            node.Next = Head;
            Head = node;
            Count += 1;
        }
        return true;
    }
    
    /** Adds an item at the rear of Deque. Return true if the operation is successful. */
    public bool InsertLast(int value) {
        if(K == Count) return false;
        if(Head == null){
            Node node = new Node(value);
            Head = node;
            Tail = node;
            Count += 1;
        } else {
            Node node = new Node(value);
            node.Prev = Tail;
            Tail.Next = node;
            Tail = node;
            Count += 1;
        }
        return true;
    }
    
    /** Deletes an item from the front of Deque. Return true if the operation is successful. */
    public bool DeleteFront() {
        if(Count == 0) return false;
        if(Count == 1) {
            Head = null;
            Tail = null;
            Count = 0;
        } else {
            Node tmp = Head;
            Head = Head.Next;
            tmp.Next = null;
            Head.Prev = null;
            Count -= 1;
        }
        return true;
    }
    
    /** Deletes an item from the rear of Deque. Return true if the operation is successful. */
    public bool DeleteLast() {
        if(Count == 0) return false;
        if(Count == 1) {
            Head = null;
            Tail = null;
            Count = 0;
        } else {
            Node tmp = Tail;
            Tail = Tail.Prev;
            tmp.Prev = null;
            Tail.Next = null;
            Count -= 1;
        }
        return true;
    }
    
    /** Get the front item from the deque. */
    public int GetFront() {
        if(Count == 0) return -1;
        return Head.Val;
    }
    
    /** Get the last item from the deque. */
    public int GetRear() {
        if(Count == 0) return -1;
        return Tail.Val;
    }
    
    /** Checks whether the circular deque is empty or not. */
    public bool IsEmpty() {
        return Count == 0;
    }
    
    /** Checks whether the circular deque is full or not. */
    public bool IsFull() {
        return Count == K;
    }
}

/**
 * Your MyCircularDeque object will be instantiated and called as such:
 * MyCircularDeque obj = new MyCircularDeque(k);
 * bool param_1 = obj.InsertFront(value);
 * bool param_2 = obj.InsertLast(value);
 * bool param_3 = obj.DeleteFront();
 * bool param_4 = obj.DeleteLast();
 * int param_5 = obj.GetFront();
 * int param_6 = obj.GetRear();
 * bool param_7 = obj.IsEmpty();
 * bool param_8 = obj.IsFull();
 */
