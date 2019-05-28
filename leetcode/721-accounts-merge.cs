//https://leetcode.com/problems/accounts-merge/

//Sort and Hash, it can be solved by Trie as well.

public class Solution {
    public string LongestWord(string[] words) {
        Array.Sort(words);
        int max = 0;
        string candidate = "";
        HashSet<string> hs = new HashSet<string>();
        hs.Add("");
        foreach(string w in words){
            if(hs.Contains(w.Substring(0, w.Length-1))) {
                if(w.Length > max) {
                    max = w.Length;
                    candidate = w;
                }
                hs.Add(w);
            }
        }
        return candidate;
    }
}
