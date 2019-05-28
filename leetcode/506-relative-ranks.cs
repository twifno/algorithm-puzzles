//https://leetcode.com/problems/relative-ranks/

public class Solution {
    class Athlete {
        public int Score;
        public int Pos;
        public Athlete(int s, int p){
            Score = s;
            Pos = p;
        }
    }
    
    public string[] FindRelativeRanks(int[] nums) {
        int len = nums.Length;
        string[] res = new string[len];
        Athlete[] ath = new Athlete[len];
        
        for(int i = 0; i < nums.Length; i++){
            ath[i] = new Athlete(nums[i], i);
        }
        
        Array.Sort(ath, (x, y) => y.Score.CompareTo(x.Score));
        
        for(int i = 0; i < len; i++){
            if(i == 0) res[ath[i].Pos] = "Gold Medal";
            else if(i == 1) res[ath[i].Pos] = "Silver Medal";
            else if(i == 2) res[ath[i].Pos] = "Bronze Medal";
            else res[ath[i].Pos] = (i+1).ToString();
        }
        
        return res;
    }
}
