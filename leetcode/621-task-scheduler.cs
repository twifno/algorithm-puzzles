//https://leetcode.com/problems/task-scheduler/

public class Solution {
    public int LeastInterval(char[] tasks, int n) {
        int max = 0;
        int[] counts = new int[26];
        foreach(char t in tasks) counts[t-'A'] += 1;
        foreach(int c in counts) max = Math.Max(c, max);
        int count = 0;
        foreach(int c in counts) if(c == max) count += 1;
        return Math.Max(tasks.Length, (n+1)*(max-1) + count);
    }
}
