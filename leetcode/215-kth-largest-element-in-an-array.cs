//https://leetcode.com/problems/kth-largest-element-in-an-array/

//Kind of Quick Sort.

public class Solution {
    public int FindKthLargest(int[] nums, int k) {
        int left = 0;
        int right = nums.Length-1;
        while(true){
            int val = nums[left];
            int mid = part(nums, left, right, val);
            System.Console.WriteLine(mid);
            if(mid == k-1) return nums[mid];
            else if(mid < k-1) left = mid+1;
            else right = mid-1;          
        }
        return 0;
    }
    
    private int part(int[] nums, int left, int right, int val){
        int cur = left;
        for(int i = left; i <= right; i++){
            if(nums[i] >= val) {
                int tmp = nums[i];
                nums[i] = nums[cur];
                nums[cur] = tmp;
                cur += 1;
            }
        }
        int head = nums[left];
        nums[left] = nums[cur-1];
        nums[cur-1] = head;
        return cur-1;
    }
}
