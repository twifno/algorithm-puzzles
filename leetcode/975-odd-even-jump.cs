//https://leetcode.com/problems/odd-even-jump/

public class Solution {
    
    class Node {
        public int Val;
        public int Pos;
        public Node(int v, int p){
            Val = v;
            Pos = p;
        }
    }
    public int OddEvenJumps(int[] A) {
        int len = A.Length;
        Node[] nodes = new Node[len];
        for(int i = 0; i < len; i++){
            nodes[i] = new Node(A[i], i);
        }
        Array.Sort(nodes, (x, y) => (x.Val == y.Val)?x.Pos.CompareTo(y.Pos):x.Val.CompareTo(y.Val));
        int[] odds = new int[len];
        Stack<Node> st = new Stack<Node>();
        foreach(Node n in nodes){
            while(st.Count > 0 && st.Peek().Pos < n.Pos){
                odds[st.Pop().Pos] = n.Pos;
            }
            st.Push(n);
        }
        Array.Sort(nodes, (x, y) => (x.Val == y.Val)?x.Pos.CompareTo(y.Pos):y.Val.CompareTo(x.Val));
        int[] evens = new int[len];
        st.Clear();
        foreach(Node n in nodes){
            while(st.Count > 0 && st.Peek().Pos < n.Pos){
                evens[st.Pop().Pos] = n.Pos;
            }
            st.Push(n);
        }
        Dictionary<string, bool> cache = new Dictionary<string, bool>();
        int count = 0;
        for(int i = 0; i < len; i++){
            if(Check(i, len, odds, evens, true, cache)) count += 1;
            //System.Console.WriteLine(Check(i, len, odds, evens, true, cache));
        }
        //for(int i = 0; i < len; i++) System.Console.WriteLine(odds[i]);
        //System.Console.WriteLine("*****");
        //for(int i = 0; i < len; i++) System.Console.WriteLine(evens[i]);
        return count;
    }
    
    private bool Check(int i, int len, int[] odds, int[] evens, bool isOdd, Dictionary<string, bool> cache) {
        if(i == len - 1) return true;
        string key = i + ":" + isOdd;
        if(cache.ContainsKey(key)) return cache[key];
        if(isOdd && odds[i] == 0) { cache[key] = false; return false; }
        if(!isOdd && evens[i] == 0) { cache[key] = false; return false; }
        cache[key] = Check(isOdd?odds[i]:evens[i], len, odds, evens, !isOdd, cache);
        return cache[key];
    }
}
