//https://leetcode.com/problems/distribute-candies/

public class Solution {
    public int DistributeCandies(int[] candies) {
        HashSet<int> kinds = new HashSet<int>();
        foreach(int c in candies) kinds.Add(c);
        return Math.Min(kinds.Count, candies.Length/2);
    }
}
