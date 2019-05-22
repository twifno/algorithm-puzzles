//https://leetcode.com/problems/substring-with-concatenation-of-all-words/

public class Solution {
    public IList<int> FindSubstring(string s, string[] words) {
        Dictionary<string, int> dict = new Dictionary<string, int>();
        foreach(string w in words){
            if(dict.ContainsKey(w)) dict[w] += 1;
            else dict[w] = 1;
        }
        List<int> res = new List<int>();
        if(words.Length == 0) return res;
        int wl = words[0].Length;
        for(int i = 0; i < wl && i < s.Length; i++){
            int start = i;
            int num = 0;
            Queue<string> q = new Queue<string>();
            while(start + wl <= s.Length){
                string k = s.Substring(start, wl);
                if(dict.ContainsKey(k)) {
                    if(dict[k] > 0) {
                        dict[k] -= 1;
                        num += 1;
                        q.Enqueue(k);
                    } else {
                        while(dict[k] <= 0){
                            dict[q.Dequeue()] += 1;
                            num -= 1;
                        }
                        dict[k] -= 1;
                        num += 1;
                        q.Enqueue(k);
                    }
                } else {
                    num = 0;
                    while(q.Count > 0) { dict[q.Dequeue()] += 1; }
                }
                if(num == words.Length) res.Add(start - wl * (words.Length-1));
                start += wl;
            }
            while(q.Count > 0) { dict[q.Dequeue()] += 1; }
        }
        return res;
    }
}
