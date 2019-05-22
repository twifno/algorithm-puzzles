//https://leetcode.com/problems/next-permutation/

/* 
General algorithm for next permutation
1, find the last element that smaller than its next element e1 in position p1
2, find the last element that larger than e1, say e2
3, swap e1 and e2,
4, sort all elements after p1
*/
public class Solution {
    public void NextPermutation(int[] nums) {
        if(nums.Length <= 1) return;
        int cur = nums.Length-2;
        while(cur >= 0 && nums[cur] >= nums[cur+1]) cur -= 1;
        if(cur == -1) {
            Array.Sort(nums);
            return;
        }
        int rep = nums.Length - 1;
        while(rep > cur && nums[rep] <= nums[cur]) rep -= 1;
        int tmp = nums[rep];
        nums[rep] = nums[cur];
        nums[cur] = tmp;
        Array.Sort(nums, cur+1, nums.Length - 1 - cur);
        return;
    }
}
