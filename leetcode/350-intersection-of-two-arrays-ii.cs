//https://leetcode.com/problems/intersection-of-two-arrays-ii/

public class Solution {
    public int[] Intersect(int[] nums1, int[] nums2) {
        Dictionary<int, int> mask = new Dictionary<int, int>();
        List<int> res = new List<int>();
        foreach(int n in nums1){
            if(!mask.ContainsKey(n)) mask[n] = 0;
            mask[n] += 1;
        }
        foreach(int n in nums2){
            if(!mask.ContainsKey(n)) continue;
            if(mask[n] > 0){
                mask[n] -= 1;
                res.Add(n);
            }
        }
        return res.ToArray();
    }
}
