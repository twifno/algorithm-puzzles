//https://leetcode.com/problems/open-the-lock/

public class Solution {
    class Move{
        public string Val;
        public int Count;
        public Move(string v, int c){
            Val = v;
            Count = c;
        }
    }
    
    public int OpenLock(string[] deadends, string target) {
        HashSet<string> visited = new HashSet<string>();
        foreach(string d in deadends) visited.Add(d);
        if(visited.Contains("0000")) return -1;
        Queue<Move> q = new Queue<Move>();
        q.Enqueue(new Move("0000", 0));
        while(q.Count > 0){
            Move current = q.Dequeue();
            if(current.Val == target) return current.Count;
            Move[] nexts = GetNext(current);
            foreach(Move m in nexts){
                if(!visited.Contains(m.Val)){
                    visited.Add(m.Val);
                    q.Enqueue(m);
                }            
            }
        }
        return -1;
    }
    
    private char[] NextDigit = { '1', '2', '3', '4', '5', '6', '7', '8', '9', '0'};
    private char[] PrevDigit = { '9', '0', '1', '2', '3', '4', '5', '6', '7', '8'};
    
    private Move[] GetNext(Move cur){
        Move[] res = new Move[8];
        char[] cs = cur.Val.ToCharArray();
        for(int i = 0; i < 8; i++){
            int pos = i / 2;
            int dir = i % 2;
            char tmp = cs[pos];
            if(dir == 1){
                cs[pos] = NextDigit[tmp-'0'];
            } else {
                cs[pos] = PrevDigit[tmp-'0'];
            }
            res[i] = new Move(new string(cs), cur.Count+1);
            cs[pos] = tmp;
        }
        return res;
    }
}
