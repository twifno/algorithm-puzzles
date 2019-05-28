//https://leetcode.com/problems/teemo-attacking/

public class Solution {
    public int FindPoisonedDuration(int[] timeSeries, int duration) {
        int sum = 0;
        for(int i = 0; i < timeSeries.Length; i++){
            int dur = duration;
            if(i < timeSeries.Length-1){
                dur = Math.Min(dur, timeSeries[i+1] - timeSeries[i]);
            }
            sum += dur;
        }
        return sum;
    }
}
