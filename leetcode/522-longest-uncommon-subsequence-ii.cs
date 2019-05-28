//https://leetcode.com/problems/longest-uncommon-subsequence-ii/

public class Solution {
    public int FindLUSlength(string[] strs) {
        Array.Sort(strs, (x, y) => (y.Length==x.Length)?x.CompareTo(y):y.Length.CompareTo(x.Length));
        HashSet<string> occurs = new HashSet<string>();
        for(int i = 0; i < strs.Length; i++){
            if(occurs.Contains(strs[i])) continue;
            bool isSubSeq = false;
            foreach(string s in occurs) {
                if(CheckSubSeq(s, strs[i])) {
                    isSubSeq = true;
                    break;
                }
            }
            if(isSubSeq) continue;
            occurs.Add(strs[i]);
            if(i < strs.Length-1 && strs[i] == strs[i+1]) continue;
            return strs[i].Length;
        }
        return -1;
    }
    
    private bool CheckSubSeq(string s1, string s2){
        int p1 = 0;
        int p2 = 0;
        while(p1 < s1.Length && p2 < s2.Length){
            if(s1[p1] == s2[p2]) {
                p2 += 1;
            }
            p1 += 1;
        }
        if(p2 == s2.Length) return true;
        return false;
    }
}
