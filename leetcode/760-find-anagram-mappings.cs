//https://leetcode.com/problems/find-anagram-mappings/

public class Solution {
    public int[] AnagramMappings(int[] A, int[] B) {
        Dictionary<int, Queue<int>> map = new Dictionary<int, Queue<int>>();
        for(int i = 0; i < B.Length; i++){
            if(!map.ContainsKey(B[i])) map[B[i]] = new Queue<int>();
            map[B[i]].Enqueue(i);
        }
        int[] res = new int[A.Length];
        for(int i = 0; i < res.Length; i++){
            res[i] = map[A[i]].Dequeue();
        }   
        return res;
    }
}
