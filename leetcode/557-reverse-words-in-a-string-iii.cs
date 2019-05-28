//https://leetcode.com/problems/reverse-words-in-a-string-iii/

public class Solution {
    public string ReverseWords(string s) {
        string[] ss = s.Split(" ");
        for(int i = 0; i < ss.Length; i++){
            char[] cs = ss[i].ToCharArray();
            Array.Reverse(cs);
            ss[i] = new string(cs);
        }
        return string.Join(" ", ss);
    }
}
