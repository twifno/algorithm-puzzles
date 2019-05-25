//https://leetcode.com/problems/sliding-window-maximum/

//Monotonic double queue.

public class Solution {
    public int[] MaxSlidingWindow(int[] nums, int k) {
        if(k == 0) return new int[0]{};
        LinkedList<int> pos = new LinkedList<int>();
        for(int i = 0; i < k-1; i++){
            while(pos.Count > 0 && nums[pos.Last.Value] <= nums[i]) pos.RemoveLast();
            pos.AddLast(i);
        }
        int[] res = new int[nums.Length-k+1];
        for(int i = k-1; i < nums.Length; i++){
            while(pos.Count > 0 && nums[pos.Last.Value] <= nums[i]) pos.RemoveLast();
            pos.AddLast(i);
            res[i-k+1] = nums[pos.First.Value];
            if(pos.First.Value <= i-k+1) pos.RemoveFirst();
        }
        return res;
    }
}
