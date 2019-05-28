//https://leetcode.com/problems/poor-pigs/

public class Solution {
    public int PoorPigs(int buckets, int minutesToDie, int minutesToTest) {
        int round = minutesToTest / minutesToDie;
        return (int)Math.Ceiling(Math.Log(buckets, round+1));
    }
}
