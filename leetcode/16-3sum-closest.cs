//https://leetcode.com/problems/3sum-closest/

//Two point approach

public class Solution {
    public int ThreeSumClosest(int[] nums, int target) {
        if(nums.Length < 3) return 0;
        Array.Sort(nums, (x,y) => x.CompareTo(y));
        int distance = Int32.MaxValue;
        int ret = target;
        for(int i = 0; i < nums.Length - 2; i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int cur = nums[i];
            int front = i+1;
            int back = nums.Length-1;
            while(front < back){
                int sum = nums[front] + nums[back] + cur;
                if(sum < target){
                    if(target-sum < distance){
                        distance = target - sum;
                        ret = sum;
                    }
                    front += 1;
                } else if (sum > target){
                    if(sum-target < distance){
                        distance = sum - target;
                        ret = sum;
                    }
                    back -= 1;
                } else {
                    return target;
                }
            }
        }
        return ret;
    }
}
