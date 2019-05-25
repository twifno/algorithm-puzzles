//https://leetcode.com/problems/generalized-abbreviation/

//Back tracking.

public class Solution {
    public IList<string> GenerateAbbreviations(string word) {
        List<string> res = new List<string>();
        if(word.Length == 0) return new List<string>(){""};
        int len = word.Length;
        int cur = 0;
        while(cur < len){
            if(cur == 0){
                res.Add("1");
                res.Add(word[0].ToString());
            } else {
                List<string> tmp = new List<string>();
                foreach(string s in res) {
                    tmp.Add(s+word[cur]);
                    tmp.Add(MergeOne(s));
                }
                res = tmp;
            }
            cur += 1;
        }
        return res;
    }
    
    private string MergeOne(string s){
        int len = s.Length;
        if(s[len-1] > '9' || s[len-1] < '0') return s+"1";
        int cur = len - 1;
        while(cur >= 0){
            char c = s[cur];
            if(c >= '0' && c <= '9') cur -= 1;
            else break;
        }
        cur += 1;
        string head = s.Substring(0, cur);
        string tail = s.Substring(cur, len-cur);
        int num = Int32.Parse(tail);
        return head + (num+1);
    }
}

//We can also use bits to represent char and abbr
