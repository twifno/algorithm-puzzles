//https://leetcode.com/problems/group-shifted-strings/

public class Solution {
    public IList<IList<string>> GroupStrings(string[] strings) {
        Dictionary<string, List<string>> buckets = new Dictionary<string, List<string>>();
        foreach(string s in strings){
            int[] code = new int[s.Length];
            int b = s[0] - 'a';
            for(int i = 0; i < code.Length; i++){
                code[i] = s[i] - 'a' - b;
                if(code[i] < 0) code[i] += 26;
            }
            string k = string.Join(':', code);
            if(!buckets.ContainsKey(k)) buckets[k] = new List<string>();
            buckets[k].Add(s);
        }
        
        List<IList<string>> res = new List<IList<string>>();
        foreach(List<string> list in buckets.Values) res.Add(list);
        return res;
    }
}
