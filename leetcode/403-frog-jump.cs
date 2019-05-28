//https://leetcode.com/problems/frog-jump/

//DP in each steps

public class Solution {
    public bool CanCross(int[] stones) {
        Dictionary<int, HashSet<int>> dict = new Dictionary<int, HashSet<int>>();
        foreach(int pos in stones){
            dict[pos] = new HashSet<int>();
        }
        if(stones[1] != 1) return false;
        if(stones.Length == 2) return true;
        dict[1].Add(1);
        int cur = 1;
        while(cur < stones.Length-1){   
            int pos = stones[cur];
            foreach(int jump in dict[pos]){
                if(jump > 1 && dict.ContainsKey(pos+jump-1)) dict[pos+jump-1].Add(jump-1);
                if(dict.ContainsKey(pos+jump)) dict[pos+jump].Add(jump);
                if(dict.ContainsKey(pos+jump+1)) dict[pos+jump+1].Add(jump+1);
            }
            cur += 1;
            if(dict[stones[stones.Length-1]].Count > 0) return true;
        }
        return false;
    }
}
