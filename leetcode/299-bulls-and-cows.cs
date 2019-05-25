//https://leetcode.com/problems/bulls-and-cows/

//Count cows and then count bulls.

public class Solution {
    public string GetHint(string secret, string guess) {
        int[] counts = new int[10];
        foreach(char c in secret) {
            counts[c - '0'] += 1;
        }
        int count = 0;
        foreach(char c in guess) {
            if(counts[c - '0'] > 0) {
                counts[c - '0'] -= 1;
                count += 1;
            }
        }
        int same = 0;
        for(int i = 0; i < secret.Length; i++){
            if(secret[i] == guess[i]) same += 1;
        }
        return same.ToString()+"A"+(count-same)+"B";
    }
}
