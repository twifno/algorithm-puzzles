//https://leetcode.com/problems/majority-element-ii/

public class Solution {
    public IList<int> MajorityElement(int[] nums) {
        int c1 = 0;
        int c2 = 0;
        int n1 = 0;
        int n2 = 0;
        foreach(int n in nums){
            if(n == c1) n1 += 1;
            else if(n == c2) n2 += 1;
            else if(n1 == 0) { c1 = n; n1 = 1; }
            else if(n2 == 0) { c2 = n; n2 = 1; }
            else { n1 -= 1; n2 -= 1; }
        }
        n1 = 0; n2 = 0;
        foreach(int n in nums){
            if(n == c1) n1 += 1;
            else if(n == c2) n2 += 1;
        }
        List<int> res = new List<int>();
        if(n1 > nums.Length/3) res.Add(c1);
        if(n2 > nums.Length/3) res.Add(c2);
        return res;
    }
}
