//https://leetcode.com/problems/license-key-formatting/

//It can be done by starting from the end too.

public class Solution {
    public string LicenseKeyFormatting(string S, int K) {
        S = S.ToUpper();
        int count = 0;
        foreach(char c in S) if(c != '-') count += 1;
        int rem = count % K;
        StringBuilder sb = new StringBuilder();
        count = 0;
        for(int i = 0; i < S.Length; i++){
            if(S[i] != '-'){
                sb.Append(S[i]);
                count += 1;
                if((count - rem) % K == 0) sb.Append('-');
            }
        }
        return sb.ToString().TrimEnd('-');
    }
}
