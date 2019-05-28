//https://leetcode.com/problems/unique-morse-code-words/

public class Solution {
    public int UniqueMorseRepresentations(string[] words) {
        string[] map = {".-","-...","-.-.","-..",".","..-.","--.","....","..",".---","-.-",".-..","--","-.","---",".--.","--.-",".-.","...","-","..-","...-",".--","-..-","-.--","--.."};
        HashSet<string> hs = new HashSet<string>();
        foreach(string s in words){
            StringBuilder sb = new StringBuilder();
            foreach(char c in s){
                sb.Append(map[c-'a']);
            }
            hs.Add(sb.ToString());
        }
        return hs.Count;
    }
}
