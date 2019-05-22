//https://leetcode.com/problems/median-of-two-sorted-arrays/

//Binary Search

public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int l1 = nums1.Length;
        int l2 = nums2.Length;
        if(l1 > l2) {
            int[] tmp = nums1;
            nums1 = nums2;
            nums2 = tmp;
            l1 = nums1.Length;
            l2 = nums2.Length;
        }
        int left = 0, right = l1;
        int half = (l1+l2+1)/2;
        while(left <= right){
            int mid1 = left + (right-left)/2;
            int mid2 = half - mid1;
            if(mid1 > 0 && nums1[mid1-1] > nums2[mid2]){
                right = mid1 - 1;
            } else if (mid1 < right && nums1[mid1] < nums2[mid2-1]){
                left = mid1 + 1;
            } else {
                int leftmax = 0;
                if(mid1 == 0){
                    leftmax = nums2[mid2-1];
                } else if(mid2 == 0) {
                    leftmax = nums1[mid1-1];
                }else {
                    leftmax = Math.Max(nums1[mid1-1], nums2[mid2-1]);
                }
                if((l1+l2) % 2 == 1) return leftmax;
                
                int rightmin = 0;
                if(mid1 == l1){
                    rightmin = nums2[mid2];
                } else if(mid2 == l2) {
                    rightmin = nums1[mid1];
                } else {
                    rightmin = Math.Min(nums1[mid1], nums2[mid2]);
                }
                return (leftmax + rightmin) / 2.0;
            }
        }
        return -1;
    }
}
