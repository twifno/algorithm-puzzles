//https://leetcode.com/problems/all-oone-data-structure/

//Double linked list and Dictionary.

public class AllOne {
    
    class Node {
        public Node Prev;
        public Node Next;
        public int Count;
        public HashSet<string> Set;
        public Node(int c) {
            Count = c; 
            Set = new HashSet<string>();
        }
    }
    
    Dictionary<string, Node> Rank;
    
    Node Head;
    Node Tail;

    /** Initialize your data structure here. */
    public AllOne() {
        Head = new Node(0);
        Tail = new Node(0);
        Head.Next = Tail;
        Tail.Prev = Head;
        Rank = new Dictionary<string, Node>();
    }
    
    /** Inserts a new key <Key> with value 1. Or increments an existing key by 1. */
    public void Inc(string key) {
        if(Rank.ContainsKey(key)) {
            Node n = Rank[key];
            if(n.Next == Tail || n.Next.Count > n.Count + 1) {
                Node next = new Node(n.Count+1);
                next.Set.Add(key);
                next.Next = n.Next;
                n.Next.Prev = next;
                n.Next = next;
                next.Prev = n;
            } else {
                n.Next.Set.Add(key);
            }
            Rank[key] = n.Next;
            n.Set.Remove(key);
            if(n.Set.Count == 0) Remove(n);
        } else {
            Node n = Head.Next;
            if(n.Count != 1) {
                Node one = new Node(1);
                one.Next = n;
                one.Prev = Head;
                Head.Next = one;
                n.Prev = one;
                n = one;
            }          
            Rank[key] = n;
            n.Set.Add(key);
            
        }
    }
    
    private void Remove(Node n) {
        n.Prev.Next = n.Next;
        n.Next.Prev = n.Prev;
        n.Next = null;
        n.Prev = null;
    }
    
    /** Decrements an existing key by 1. If Key's value is 1, remove it from the data structure. */
    public void Dec(string key) {
        if(Rank.ContainsKey(key)) {
            Node n = Rank[key];
            if(n.Count == 1) {
                //System.Console.WriteLine(n.Set.Count);
                n.Set.Remove(key);
                Rank.Remove(key);
                if(n.Set.Count == 0) Remove(n);
            } else if(n.Prev == Head || n.Prev.Count < n.Count-1){
                Node prev = new Node(n.Count-1);
                prev.Set.Add(key);
                prev.Next = n;
                prev.Prev = n.Prev;
                n.Prev.Next = prev;
                n.Prev = prev;
                Rank[key] = prev;
                n.Set.Remove(key);
                if(n.Set.Count == 0) Remove(n);
            } else {
                n.Prev.Set.Add(key);
                Rank[key] = n.Prev;
                n.Set.Remove(key);
                if(n.Set.Count == 0) Remove(n);
            }
        }
    }
    
    /** Returns one of the keys with maximal value. */
    public string GetMaxKey() {
        //Print();
        if(Head.Next == Tail) return "";
        return Tail.Prev.Set.First();
    }
    
    /** Returns one of the keys with Minimal value. */
    public string GetMinKey() {
        //Print();
        if(Head.Next == Tail) return "";
        return Head.Next.Set.First();
    }
    
    private void Print(){
        Node cur = Head;
        while(cur != null){
            System.Console.WriteLine(cur.Count);
            cur = cur.Next;
        }
    }
}

/**
 * Your AllOne object will be instantiated and called as such:
 * AllOne obj = new AllOne();
 * obj.Inc(key);
 * obj.Dec(key);
 * string param_3 = obj.GetMaxKey();
 * string param_4 = obj.GetMinKey();
 */
