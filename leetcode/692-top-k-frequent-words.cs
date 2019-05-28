//https://leetcode.com/problems/top-k-frequent-words/

public class Solution {
    public IList<string> TopKFrequent(string[] words, int k) {
        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach(string w in words){
            if(!counts.ContainsKey(w)) counts[w] = 1;
            else counts[w] += 1;
        }
        SortedDictionary<int, SortedSet<string>> q = new SortedDictionary<int, SortedSet<string>>();
        int size = 0;
        foreach(string key in counts.Keys){
            int count = counts[key];
            if(!q.ContainsKey(count)) {
                q[count] = new SortedSet<string>();
            }
            q[count].Add(key);
            size += 1;
            if(size > k){
                int first = q.First().Key;
                SortedSet<string> ss = q[first];
                string last = ss.Last();
                ss.Remove(last);
                if(ss.Count == 0) q.Remove(first);
                size -= 1;
            }
        }
        List<string> res = new List<string>();
        List<int> keys = new List<int>(q.Keys);
        keys.Reverse();
        foreach(int key in keys){
            foreach(string s in q[key]) res.Add(s);
        }
        return res;
    }
}
