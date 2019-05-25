//https://leetcode.com/problems/top-k-frequent-elements/

public class Solution {
    public IList<int> TopKFrequent(int[] nums, int k) {
        Dictionary<int, int> freqs = new Dictionary<int, int>();
        foreach(int n in nums){
            if(!freqs.ContainsKey(n)) freqs[n] = 0;
            freqs[n] += 1;
        }
        List<int>[] ranks = new List<int>[nums.Length+1];
        foreach(int n in freqs.Keys){
            int f = freqs[n];
            if(ranks[f] == null) ranks[f] = new List<int>();
            ranks[f].Add(n);
        }
        List<int> res = new List<int>();
        for(int i = nums.Length; i > 0; i--){
            if(ranks[i] != null && k > 0){
                k -= ranks[i].Count;
                res.AddRange(ranks[i]);
            }
        }
        return res;
    }
}
