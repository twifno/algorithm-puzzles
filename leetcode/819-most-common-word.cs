//https://leetcode.com/problems/most-common-word/

public class Solution {
    public string MostCommonWord(string paragraph, string[] banned) {
        paragraph = paragraph.ToLower();
        string res = "";
        int max = 0;
        HashSet<string> hs = new HashSet<string>(banned);
        Dictionary<string, int> counts = new Dictionary<string, int>();
        List<string> words = new List<string>();
        int cur = 0;
        while(cur < paragraph.Length){
            int start = -1;
            while(cur < paragraph.Length && !IsAB(paragraph[cur])) cur += 1;
            if(cur == paragraph.Length) break;
            start = cur;
            while(cur < paragraph.Length && IsAB(paragraph[cur])) cur += 1;
            words.Add(paragraph.Substring(start, cur-start));
        }
        foreach(string w in words){
            if(hs.Contains(w)) continue;
            if(counts.ContainsKey(w)) counts[w] += 1;
            else counts[w] = 1;
            if(counts[w] > max) {
                max = counts[w];
                res = w;
            }
        }
        return res;
    }
    
    private bool IsAB(char c) {
        return c >= 'a' && c <= 'z';
    }
}
