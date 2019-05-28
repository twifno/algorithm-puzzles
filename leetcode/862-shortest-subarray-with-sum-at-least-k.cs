//https://leetcode.com/problems/shortest-subarray-with-sum-at-least-k/

public class Solution {
    public int ShortestSubarray(int[] A, int K) {
        int len = A.Length;
        int[] sums = new int[len];
        int sum = 0;
        int min = Int32.MaxValue;
        for(int i = 0; i < len; i++) {
            sum += A[i];
            sums[i] = sum;
            if(sum >= K && min == Int32.MaxValue) min = i+1;
        }
        LinkedList<int> list = new LinkedList<int>();
        for(int i = 0; i < len; i++){
            while(list.Count > 0 && sums[list.Last.Value] >= sums[i]) list.RemoveLast();
            while(list.Count > 0 && sums[i] - sums[list.First.Value] >= K){
                min = Math.Min(i - list.First.Value, min);
                list.RemoveFirst();
            }
            list.AddLast(i);
        }
        if(min == Int32.MaxValue) min = -1;
        return min;
    }
}
