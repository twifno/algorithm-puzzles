//https://leetcode.com/problems/unique-paths/

//Simple combination math…
//Pay attention to the overflow!

public class Solution {
    public int UniquePaths(int m, int n) {
        m -= 1;
        n -= 1;
        if(m == 0 || n == 0) return 1;
        double sum = 1;
        for(int i = n; i < n+m; i++) { sum *= i+1; sum /= i-n+1;}
        return (int)sum;
    }
}
