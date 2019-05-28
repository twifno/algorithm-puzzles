//https://leetcode.com/problems/find-permutation/

//Reverse the array when decreasing.

public class Solution {
    public int[] FindPermutation(string s) {
        int[] res = new int[s.Length+1];
        for(int i = 0; i < res.Length; i++) res[i] = i+1;
        int start = 0;
        int end = 0;
        int pos = 1;
        while(pos <= s.Length){
            char v = s[pos-1];
            if(v == 'D') end = pos;
            else {
                if(end > start) Array.Reverse(res, start, end-start+1);
                start = pos;
            }
            pos += 1;
        }
        if(end > start) Array.Reverse(res, start, end-start+1);
        return res;
    }
}
