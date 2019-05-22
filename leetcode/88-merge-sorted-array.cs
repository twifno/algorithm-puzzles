//https://leetcode.com/problems/merge-sorted-array/

public class Solution {
    public void Merge(int[] nums1, int m, int[] nums2, int n) {
        int total = m+n;
        while(total > 0){
            if(m == 0) {
                nums1[total-1] = nums2[n-1];
                total -= 1;
                n -= 1;
            } else if (n == 0){
                nums1[total-1] = nums1[m-1];
                total -= 1;
                m -= 1;
            } else if (nums1[m-1] >= nums2[n-1]) {
                nums1[total-1] = nums1[m-1];
                total -= 1;
                m -= 1;
            } else {
                nums1[total-1] = nums2[n-1];
                total -= 1;
                n -= 1;
            }
        }
    }
}
