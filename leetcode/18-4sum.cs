//https://leetcode.com/problems/4sum/

//Two point approach. O(n^3)

public class Solution {
    public IList<IList<int>> FourSum(int[] nums, int target) {
        List<IList<int>> res = new List<IList<int>>();
        if(nums.Length < 4) return res;
        Array.Sort(nums);
        for(int i = 0; i < nums.Length-3; i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            for(int j = i+1; j < nums.Length-2; j++){
                if(j > i+1 && nums[j] == nums[j-1]) continue;
                int f = j+1;
                int b = nums.Length-1;
                while(f < b){
                    int sum = nums[i]+nums[j]+nums[f]+nums[b];
                    if(sum < target){
                        f += 1;
                    } else if (sum > target) {
                        b -= 1;
                    } else {
                        List<int> list = new List<int>();
                        list.Add(nums[i]);
                        list.Add(nums[j]);
                        list.Add(nums[f]);
                        list.Add(nums[b]);
                        res.Add(list);
                        f += 1;
                        while(f < b && nums[f] == nums[f-1]) f += 1;
                    }
                }
            }
        }
        return res;
    }
}
