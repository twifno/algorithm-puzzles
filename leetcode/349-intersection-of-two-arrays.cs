//https://leetcode.com/problems/intersection-of-two-arrays/

public class Solution {
    public int[] Intersection(int[] nums1, int[] nums2) {
        HashSet<int> res = new HashSet<int>();
        HashSet<int> mask = new HashSet<int>();
        foreach(int n in nums1) mask.Add(n);
        foreach(int n in nums2) if(mask.Contains(n)) res.Add(n);
        return res.ToArray();
    }
}
