//https://leetcode.com/problems/arranging-coins/

public class Solution {
    public int ArrangeCoins(int n) {
        int left = 0; int right = n;
        while(left <= right){
            int mid = left + (right-left)/2;
            if(mid % 2 == 0){
                int sum = mid/2*(mid+1);
                if(sum/(mid+1) != mid/2) right = mid-1;
                else if(sum == n) return mid;
                else if(sum < n) left = mid + 1;
                else right = mid - 1;
            } else {
                int sum = (mid+1)/2*mid;
                if(sum/mid != (mid+1)/2) right = mid-1;
                else if(sum == n) return mid;
                else if(sum < n) left = mid + 1;
                else right = mid - 1;
            }
        }
        if(left % 2 == 0){
            int sum = left/2*(left+1);
            if(sum/(left+1) != left/2) return left-1;
            else if(sum <= n) return left;
            else return left - 1;
        } else {
            int sum = (left+1)/2*left;
            if(sum/left != (left+1)/2) return left-1;
            else if(sum <= n) return left;              
            else return left - 1;
        }
    }
}
