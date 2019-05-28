//

//It is absolute difference
//Be care about k=0

public class Solution {
    public int FindPairs(int[] nums, int k) {
        if(k < 0) return 0;
        Dictionary<int, int> hs = new Dictionary<int, int>();
        foreach(int n in nums) {
            if(!hs.ContainsKey(n)) hs[n] = 0;
            hs[n] += 1;
        }
        int sum = 0;
        if(k == 0){
            foreach(int n in hs.Keys) if(hs[n] > 1) sum += 1;
        } else {
            foreach(int n in hs.Keys) if(hs.ContainsKey(n+k)) sum += 1;
        }
        return sum;
    }
}
