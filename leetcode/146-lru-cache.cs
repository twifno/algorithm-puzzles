//https://leetcode.com/problems/lru-cache/

//Double Linked List and HashMap

public class LRUCache {
    
    class Node {
        public Node Prev;
        public Node Next;
        public int Val;
        public int Key;
        public Node() {
        }
        public Node(int v, int k) {
            Val = v;
            Key = k;
        }
    }
    
    Node Head;
    Node Tail;
    
    Dictionary<int, Node> Dict;
    
    int Capacity;
    int Count;

    public LRUCache(int capacity) {
        Capacity = capacity;
        Dict = new Dictionary<int, Node>();
        Head = new Node();
        Tail = new Node();
        Head.Next = Tail;
        Tail.Prev = Head;
        Count = 0;
    }
    
    public int Get(int key) {
        if(!Dict.ContainsKey(key)) return -1;
        Node n = Dict[key];
        MoveToTail(n);
        return n.Val;
    }
    
    private void MoveToTail(Node n){
        n.Prev.Next = n.Next;
        n.Next.Prev = n.Prev;
        AddToTail(n);
    }
    
    private void AddToTail(Node n){
        n.Prev = Tail.Prev;
        n.Next = Tail;
        Tail.Prev = n;
        n.Prev.Next = n;
    }
    
    public void Put(int key, int value) {
        if(!Dict.ContainsKey(key)) {
            Node n = new Node(value, key);
            AddToTail(n);
            Dict[key] = n;
            Count += 1;
            if(Count > Capacity) {
                PopHead();
            }
        } else {
            Node n = Dict[key];
            n.Val = value;
            MoveToTail(n);
        }
    }
    
    private void PopHead(){
        Node n = Head.Next;
        Dict.Remove(n.Key);
        Head.Next = Head.Next.Next;
        Head.Next.Prev = Head;
        Count -= 1;
    }
}

/**
 * Your LRUCache object will be instantiated and called as such:
 * LRUCache obj = new LRUCache(capacity);
 * int param_1 = obj.Get(key);
 * obj.Put(key,value);
 */
