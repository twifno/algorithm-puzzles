//https://leetcode.com/problems/array-nesting/

public class Solution {
    public int ArrayNesting(int[] nums) {
        bool[] visited = new bool[nums.Length];
        int max = 0;
        for(int i = 0; i < nums.Length; i++){
            if(!visited[i]) {
                int count = 0;
                int next = i;
                while(!visited[next]){
                    count += 1;
                    visited[next] = true;
                    next = nums[next];
                }
                max = Math.Max(max, count);
            }
        }
        return max;
    }
}
