//https://leetcode.com/problems/perfect-number/

//Be care of 1!

public class Solution {
    public bool CheckPerfectNumber(int num) {
        if(num == 1) return false;
        int sum = 1;
        int left = 2;
        int right = num;
        while(left <= right){
            if(num % left == 0){
                sum += left;
                if(left != num/left) sum += num/left;
            }
            if(sum > num) return false;
            left += 1;
            right = num/left;
        }
        if(sum == num) return true;
        return false;
    }
}
