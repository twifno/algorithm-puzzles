//https://leetcode.com/problems/contains-duplicate-ii/

public class Solution {
    public bool ContainsNearbyDuplicate(int[] nums, int k) {
        Dictionary<int, int> dict = new Dictionary<int, int>();
        for(int i = 0; i < nums.Length; i++){
            if(!dict.ContainsKey(nums[i])) dict[nums[i]] = i;
            else {
                int dis = i - dict[nums[i]];
                if(dis <= k) return true;
                else dict[nums[i]] = i;
            }
        }
        return false;
    }
}
