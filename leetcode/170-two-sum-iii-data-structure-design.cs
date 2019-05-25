//https://leetcode.com/problems/two-sum-iii-data-structure-design/

public class TwoSum {
    Dictionary<int, int> nums;

    /** Initialize your data structure here. */
    public TwoSum() {
        nums = new Dictionary<int, int>();
    }
    
    /** Add the number to an internal data structure.. */
    public void Add(int number) {
        if(nums.ContainsKey(number)) nums[number] += 1;
        else nums[number] = 1;
    }
    
    /** Find if there exists any pair of numbers which sum is equal to the value. */
    public bool Find(int value) {
        foreach(int n in nums.Keys){
            int comp = value - n;
            if(nums.ContainsKey(comp)){
                if(comp != n) return true;
                else if(nums[comp] >= 2) return true;
            }
        }
        return false;
    }
}

/**
 * Your TwoSum object will be instantiated and called as such:
 * TwoSum obj = new TwoSum();
 * obj.Add(number);
 * bool param_2 = obj.Find(value);
 */
