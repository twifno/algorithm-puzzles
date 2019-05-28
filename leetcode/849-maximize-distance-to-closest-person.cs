//https://leetcode.com/problems/maximize-distance-to-closest-person/

//Be careful of prefix zero and suffix zero!

public class Solution {
    public int MaxDistToClosest(int[] seats) {
        int max = 0;
        int count = 0;
        for(int i = 0; i < seats.Length; i++){
            int s = seats[i];
            if(s == 1) count = 0;
            else {
                count += 1;
                if(count == i+1 || i == seats.Length-1) max = Math.Max(max, count);
                else max = Math.Max(max, (count-1)/2+1);
            }
        }
        return max;
    }
}
