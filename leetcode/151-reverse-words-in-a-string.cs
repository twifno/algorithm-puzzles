//https://leetcode.com/problems/reverse-words-in-a-string/

public class Solution {
    public string ReverseWords(string s) {
        s = s.Trim();
        string[] words = s.Split(" ");
        StringBuilder sb = new StringBuilder();
        for(int i = words.Length-1; i >= 0; i--){
            if(words[i].Length > 0) {
                //System.Console.WriteLine(words[i]);
                sb.Append(words[i]);
                sb.Append(' ');
            }
        }
        return sb.ToString().Trim();
    }
}
