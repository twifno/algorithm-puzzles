//https://leetcode.com/problems/first-bad-version/

/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n) {
        int left = 1;
        int right = n;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(IsBadVersion(mid)) right = mid - 1;
            else left = mid + 1;
        }
        if(IsBadVersion(left)) return left;
        return left + 1;
    }
}
