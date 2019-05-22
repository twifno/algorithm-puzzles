//https://leetcode.com/problems/minimum-window-substring/

//Sliding windows - grow and shrink

public class Solution {
    public string MinWindow(string s, string t) {
        int[] wc = new int[256];
        int[] pc = new int[256];
        if(t == "" || s == "") return "";
        int min = Int32.MaxValue;
        int ms = -1;
        foreach(char c in t){
            pc[c-'\0'] += 1;
        }
        int left = 0, right = 0;
        int mc = 0;
        while(right < s.Length){
            int n = s[right] - '\0';
            wc[n] += 1;
            if(wc[n] <= pc[n]) mc += 1;
            if(mc < t.Length) {
                right += 1;
                continue;
            }
            while(wc[s[left] - '\0'] > pc[s[left] - '\0']){
                wc[s[left] - '\0'] -= 1;
                left += 1;
            }
            int len = right - left + 1;
            if(min > len){
                ms = left;
                min = len;
            }
            wc[s[left] - '\0'] -= 1;
            mc -= 1;
            left += 1;
            right += 1;
        }
        if(ms == -1) return "";
        return s.Substring(ms, min);
    }
}
