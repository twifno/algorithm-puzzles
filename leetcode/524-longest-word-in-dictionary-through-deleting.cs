//https://leetcode.com/problems/longest-word-in-dictionary-through-deleting/

public class Solution {
    public string FindLongestWord(string s, IList<string> d) {
        List<string> dict = new List<string>(d);
        dict.Sort((x, y) => (x.Length == y.Length)?(x.CompareTo(y)):(y.Length.CompareTo(x.Length)));
        foreach(string w in dict){
            if(IsSubSeq(s, w)) return w;
        }
        return "";
    }
    
    private bool IsSubSeq(string s1, string s2){
        int p1 = 0;
        int p2 = 0;
        while(p1 < s1.Length && p2 < s2.Length){
            if(s1[p1] == s2[p2]) p2 += 1;
            p1 += 1;
        }
        if(p2 == s2.Length) return true;
        return false;
    }
}
