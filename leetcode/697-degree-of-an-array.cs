//https://leetcode.com/problems/degree-of-an-array/

public class Solution {
    class Num {
        public int Start;
        public int Count;
        public Num(int s) { Start = s; Count = 0; }
    }
    
    public int FindShortestSubArray(int[] nums) {
        int max = 0;
        int minLength = 0;
        Dictionary<int, Num> map = new Dictionary<int, Num>();
        for(int i = 0; i < nums.Length; i++){
            int n = nums[i];
            if(!map.ContainsKey(n)) map[n] = new Num(i);
            map[n].Count += 1;
            if(map[n].Count > max) {
                max = map[n].Count;
                minLength = i - map[n].Start + 1;
            } else if(map[n].Count == max) {
                minLength = Math.Min(minLength, i - map[n].Start + 1);
            }
        }
        return minLength;
    }
}
