//https://leetcode.com/problems/partition-equal-subset-sum/

//Can be solved by 0/1 backpack as well.

public class Solution {
    public bool CanPartition(int[] nums) {
        Array.Sort(nums);
        int sum = 0;
        foreach(int n in nums) sum += n;
        if(sum % 2 != 0) return false;
        int half = sum / 2;
        HashSet<int> reachable = new HashSet<int>();
        foreach(int n in nums){
            if(n == half) return true;
            if(n > half) return false;
            int count = reachable.Count;
            HashSet<int> newPoints = new HashSet<int>();
            newPoints.Add(n);
            foreach(int i in reachable){
                if(n+i == half) return true;
                else if(n+i < half) newPoints.Add(n+i);
            }
            foreach(int i in newPoints){
                reachable.Add(i);
            }
        }
        return false;
    }
}
