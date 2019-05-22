//https://leetcode.com/problems/longest-substring-without-repeating-characters/

//First try

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        int leng = 0;
        int curIndex = -1;
        if (s == null) return 0;
        Dictionary<char, int> sub = new Dictionary<char, int>();
        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if (curIndex == -1){
                curIndex = 0;
                leng = 1;
                sub[c] = 0;
            } else {
                if (sub.ContainsKey(c)){
                    int nextIndex = sub[c] + 1;
                    for(int j = curIndex; j < nextIndex; j++){
                        sub.Remove(s[j]);
                    }
                    curIndex = nextIndex;
                }
                sub[c] = i;
                if (leng < sub.Count) leng = sub.Count;
            }
        }
        return leng;
    }
}

//Second try

public class Solution {
    public int LengthOfLongestSubstring(string s) {
        Dictionary<char, int> indexes = new Dictionary<char, int>();
        int head = -1;
        int max = 0;
        for(int i = 0; i < s.Length; i++){
            char c = s[i];
            if(indexes.ContainsKey(c)){
                if(indexes[c] > head) head = indexes[c];      
            }
            indexes[c] = i;
            max = Math.Max(max, i-head);
        }
        return max;
    }
}


