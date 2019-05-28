//https://leetcode.com/problems/kth-largest-element-in-a-stream/

//Priority Queue

public class KthLargest {

    SortedDictionary<int, int> Q;
    int Size;
    int K;
    
    public KthLargest(int k, int[] nums) {
        K = k;
        Q = new SortedDictionary<int, int>();
        Size = 0;
        foreach(int n in nums) Add(n);
    }
    
    public int Add(int val) {
        if(Q.ContainsKey(val)) Q[val] += 1;
        else Q[val] = 1;
        if(Size < K) Size += 1;
        else {
            int key = Q.First().Key;
            Q[key] -= 1;
            if(Q[key] == 0) Q.Remove(key);
        }
        return Q.First().Key;
    }
}

/**
 * Your KthLargest object will be instantiated and called as such:
 * KthLargest obj = new KthLargest(k, nums);
 * int param_1 = obj.Add(val);
 */

