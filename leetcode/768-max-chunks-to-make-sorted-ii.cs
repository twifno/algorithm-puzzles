//https://leetcode.com/problems/max-chunks-to-make-sorted-ii/

//There is O(n) solution.

public class Solution {
    class Node {
        public int Val;
        public int Rank;
        public Node Prev;
        public Node Next;
        public Node(int val, int rank) { Val = val; Rank = rank; }
    }
    
    class Cell {
        public Queue<Node> Nodes;
        public Cell() {
            Nodes = new Queue<Node>();
        }
    }
        
    public int MaxChunksToSorted(int[] arr) {
        int[] sorts = new int[arr.Length];
        for(int i = 0; i < arr.Length; i++) sorts[i] = arr[i];
        Array.Sort(sorts);
        Node head = null;
        Node prev = null;
        int rank = 0;
        foreach(int n in sorts){
            Node node = new Node(n, rank);
            if(head == null){
                prev = node;
                head = node;
            } else {
                prev.Next = node;
                node.Prev = prev;
                prev = node;
            }
            rank += 1;
        }
        Node cur = head;
        Dictionary<int, Cell> map = new Dictionary<int, Cell>();
        while(cur != null){
            int val = cur.Val;
            if(!map.ContainsKey(val)) map[val] = new Cell();
            map[val].Nodes.Enqueue(cur);
            cur = cur.Next;
        }
        int count = 0;
        for(int i = 0; i < arr.Length; i++){
            Node next = map[arr[i]].Nodes.Dequeue();
            if(next == head) {
                head = head.Next;
                if(head != null) head.Prev = null;
                next.Next = null;
            } else {
                next.Prev.Next = next.Next;
                if(next.Next != null) next.Next.Prev = next.Prev;
                next.Prev = null;
                next.Next = null;
            }
            if(head == null || head.Rank > i) count += 1;
        }
        return count;
    }
}
