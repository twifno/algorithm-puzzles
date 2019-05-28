//https://leetcode.com/problems/next-greater-element-i/

public class Solution {
    public int[] NextGreaterElement(int[] findNums, int[] nums) {
        Stack<int> st = new Stack<int>();
        int cur = 0;
        Dictionary<int, int> greaters = new Dictionary<int, int>();
        while(cur < nums.Length){
            while(st.Count > 0 && st.Peek() < nums[cur]){
                greaters[st.Pop()] = nums[cur];
            }
            st.Push(nums[cur]);
            cur += 1;
        }
        while(st.Count > 0) greaters[st.Pop()] = -1;
        int[] res = new int[findNums.Length];
        for(int i = 0; i < findNums.Length; i++){
            res[i] = greaters[findNums[i]];
        }
        return res;
    }
}
