//https://leetcode.com/problems/3sum/

//First attempt - use dictionary - remove duplication by sorting array and skip same number in the same position

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        if(nums.Length < 3) return res;
        Dictionary<int, int> dict = new Dictionary<int, int>();
        Array.Sort(nums, (x,y) => x.CompareTo(y));
        foreach(int n in nums){
            if(dict.ContainsKey(n)) dict[n] += 1;
            else dict[n] = 1;
        }
        for(int i = 0; i < nums.Length-2; i++){
            dict[nums[i]] -= 1;
            if(i > 0 && nums[i] == nums[i-1]) continue;
            for(int j = i+1; j < nums.Length-1; j++){
                dict[nums[j]] -= 1;
                if(j > i+1 && nums[j] == nums[j-1]) continue;
                int target = -nums[i]-nums[j];
                if(dict.ContainsKey(target) && dict[target] > 0){
                    List<int> list = new List<int>();
                    list.Add(nums[i]);
                    list.Add(nums[j]);
                    list.Add(-nums[i]-nums[j]);
                    res.Add(list);
                }
            }
            for(int j = i+1; j < nums.Length-1; j++){
                dict[nums[j]] += 1;
            }
        }
        return res;
    }
}

//Second try: Two point approach

public class Solution {
    public IList<IList<int>> ThreeSum(int[] nums) {
        List<IList<int>> res = new List<IList<int>>();
        if(nums.Length < 3) return res;
        Array.Sort(nums, (x,y) => x.CompareTo(y));
        for(int i = 0; i < nums.Length - 2; i++){
            if(i > 0 && nums[i] == nums[i-1]) continue;
            int cur = nums[i];
            int front = i+1;
            int back = nums.Length-1;
            while(front < back){
                if(nums[front] + nums[back] + cur < 0){
                    front += 1;
                } else if (nums[front] + nums[back] + cur > 0){
                    back -= 1;
                } else {
                    List<int> list = new List<int>();
                    list.Add(cur);
                    list.Add(nums[front]);
                    list.Add(nums[back]);
                    res.Add(list);
                    front += 1;
                    while(front < nums.Length && nums[front] == nums[front-1]) front += 1;
                }
            }
        }
        return res;
    }
}

