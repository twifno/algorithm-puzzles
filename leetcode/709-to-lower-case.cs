//https://leetcode.com/problems/to-lower-case/

public class Solution {
    public string ToLowerCase(string str) {
        char[] cs = str.ToCharArray();
        for(int i = 0; i < cs.Length; i++){
            cs[i] = char.ToLower(cs[i]);
        }
        return new string(cs);
    }
}
