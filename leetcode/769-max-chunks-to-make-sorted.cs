//https://leetcode.com/problems/max-chunks-to-make-sorted/

public class Solution {
    public int MaxChunksToSorted(int[] arr) {
        int len = arr.Length;
        int[] mins = new int[len];
        int[] maxs = new int[len];
        maxs[0] = arr[0];
        for(int i = 1; i < len; i++) maxs[i] = Math.Max(arr[i], maxs[i-1]);
        mins[len-1] =arr[len-1];
        for(int i = len-2; i >=0; i--) mins[i] = Math.Min(arr[i], mins[i+1]);
        int count = 1;
        for(int i = 0; i < len-1; i++) if(maxs[i] < mins[i+1]) count += 1;
        return count;
    }
}
