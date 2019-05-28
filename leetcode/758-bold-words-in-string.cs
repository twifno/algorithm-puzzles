//https://leetcode.com/problems/bold-words-in-string/

public class Solution {
    public string BoldWords(string[] dict, string s) {
        int len = s.Length;
        bool[] bolds = new bool[s.Length];
        foreach(string w in dict){
            int pos = 0;
            while(pos != -1){
                pos = s.IndexOf(w, pos);
                if(pos != -1) {
                    for(int i = pos; i < pos + w.Length; i++){
                        bolds[i] = true;
                    }
                    pos += 1;
                }
            }
        }
        StringBuilder sb = new StringBuilder();
        bool start = false;
        for(int i = 0; i < s.Length; i++){
            if(bolds[i]) {
                if(!start) {
                    start = true;
                    sb.Append("<b>");
                }
            } else {
                if(start) {
                    start = false;
                    sb.Append("</b>");
                }
            }
            sb.Append(s[i]);
        }
        if(start) sb.Append("</b>");
        return sb.ToString();
    }
}
