//https://leetcode.com/problems/heaters/

//Max Min distances

public class Solution {
    public int FindRadius(int[] houses, int[] heaters) {
        int max = 0;
        int hs = 0;
        int ht = 0;
        Array.Sort(houses);
        Array.Sort(heaters);
        while(hs < houses.Length){
            while(ht < heaters.Length-1 && houses[hs] > heaters[ht]){
                ht += 1;
            }
            if(houses[hs] >= heaters[ht]){
                max = Math.Max(max, houses[hs] - heaters[ht]);
            } else if(ht == 0) {
                max = Math.Max(max, heaters[ht] - houses[hs]);
            } else {
                max = Math.Max(max, Math.Min(heaters[ht] - houses[hs], houses[hs] - heaters[ht-1]));
            }
            hs += 1;
        }
        return max;
    }
}
