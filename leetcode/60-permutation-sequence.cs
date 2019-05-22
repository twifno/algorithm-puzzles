//https://leetcode.com/problems/permutation-sequence/

//Kind of math…

public class Solution {
    public string GetPermutation(int n, int k) {
        if(n == 1) return "1";
        List<int> candidates = new List<int>();
        int b = 1;
        for(int i = 1; i <= n; i++){
            b *= i;
            candidates.Add(i);
        }
        b /= n;
        StringBuilder sb = new StringBuilder();
        k -= 1;
        for(int i = 0; i < n; i++){
            int q = k/b;
            sb.Append(candidates[q]);
            candidates.RemoveAt(q);
            k %= b;
            if(i < n-1) b = b/(n-1-i);
        }
        return sb.ToString();
    }
}
