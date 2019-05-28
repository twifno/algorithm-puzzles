//https://leetcode.com/problems/partition-labels/

public class Solution {
    public IList<int> PartitionLabels(string S) {
        Dictionary<char, int> occurs = new Dictionary<char, int>();
        Stack<int> heads = new Stack<int>();
        for(int i = 0; i < S.Length; i++){
            if(!occurs.ContainsKey(S[i])) {
                occurs[S[i]] = i;
                heads.Push(i);
            } else {
                while(heads.Count > 0 && heads.Peek() > occurs[S[i]]) heads.Pop();
            }
        }
        int end = S.Length;
        List<int> res = new List<int>();
        while(heads.Count > 0){
            res.Add(end - heads.Peek());
            end = heads.Pop();
        }
        res.Reverse();
        return res;
    }
}
