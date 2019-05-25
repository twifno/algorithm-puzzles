//https://leetcode.com/problems/increasing-triplet-subsequence/

//This problem can be solved by the general algorithm for k increasing subsequence

public class Solution {
    public bool IncreasingTriplet(int[] nums) {
        List<int> cur = new List<int>();
        foreach(int n in nums){
            int pos = Search(n, cur);
            //System.Console.WriteLine(pos);
            if(pos >= 2) return true;
            if(pos >= cur.Count) cur.Add(n);
            if(pos >= 0) cur[pos] = n;
        }
        return false;
    }
    
    private int Search(int num, List<int> cur){
        int left = 0;
        int right = cur.Count-1;
        while(left <= right){
            int mid = left + (right - left)/2;
            if(cur[mid] == num) return mid;
            else if(cur[mid] < num) left = mid + 1;
            else right = mid - 1;
        }
        if(left < cur.Count && cur[left] < num) left += 1;
        return left;
    }
}
