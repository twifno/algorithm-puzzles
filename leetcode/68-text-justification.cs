//https://leetcode.com/problems/text-justification/

public class Solution {
    public IList<string> FullJustify(string[] words, int maxWidth) {
        int cur = 0;
        List<string> res = new List<string>();
        int next = 0;
        while(next < words.Length) {
            next = GetNext(words, cur, maxWidth);
            res.Add(Construct(cur, next, words, maxWidth));
            cur = next;
        }
        return res;
    }
    
    private int GetNext(string[] words, int cur, int maxWidth){
        int count = 0;
        int len = 0;
        while(cur < words.Length){
            count += 1;
            len += words[cur].Length;
            if(len+count-1 > maxWidth) return cur;
            cur += 1;
        }
        return cur;
    }
    
    private string Construct(int start, int end, string[] words, int maxWidth){
        if(end >= words.Length || end-start == 1) {
            string content = string.Join(" ", words, start, end-start);
            return content + (new string(' ', maxWidth-content.Length));
        }
        int len = 0;
        for(int i = start; i < end; i++) len += words[i].Length;
        int space = maxWidth - len;
        int count = end - start;
        int sc = count - 1;
        int dn = space / sc;
        int edn = space % sc;
        StringBuilder sb = new StringBuilder();
        for(int i = 0; i < count; i++){
            sb.Append(words[start+i]);
            if(i < count-1) {
                sb.Append(new string(' ', dn));
            }
            if(i < edn) sb.Append(' ');
        }
        return sb.ToString();
    }
}
