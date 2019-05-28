//https://leetcode.com/problems/reorder-log-files/

public class Solution {
    public string[] ReorderLogFiles(string[] logs) {
        List<string> digits = new List<string>();
        List<string> letters = new List<string>();
        
        Populate(logs, digits, letters);
        
        letters.Sort(delegate(string log1, string log2) {
            int idx1 = log1.IndexOf(' ');
            int idx2 = log2.IndexOf(' ');
            string id1 = log1.Substring(0, idx1);
            string id2 = log2.Substring(0, idx2);
            string t1 = log1.Substring(idx1+1, log1.Length-idx1-1);
            string t2 = log2.Substring(idx2+1, log2.Length-idx2-1);
            if(t1 == t2) return id1.CompareTo(id2);
            return t1.CompareTo(t2);
        });
        
        letters.AddRange(digits);
        
        return letters.ToArray();
    }
    
    private void Populate(string[] logs, List<string> digits, List<string> letters) {
        foreach(string log in logs){
            int idx = log.IndexOf(' ')+1;
            if(log[idx] >= '0' && log[idx] <= '9') digits.Add(log);
            else letters.Add(log);
        }
    }
}
