//https://leetcode.com/problems/is-subsequence/

public class Solution {
    public bool IsSubsequence(string s, string t) {
        int pos1 = 0; int pos2 = 0;
        while(pos1 < s.Length && pos2 < t.Length) {
            if(s[pos1] == t[pos2]) {
                pos1 += 1;  
            } 
            pos2 += 1;
        }
        if(pos1 == s.Length) return true;
        return false;
    }
}

//Handling multiple s.

public class Solution {
    public bool IsSubsequence(string s, string t) {
        List<int>[] chars = new List<int>[26];
        for(int i = 0; i < 26; i++){
            chars[i] = new List<int>();
        }
        for(int i = 0; i < t.Length; i++){
            chars[t[i] - 'a'].Add(i);
        }
        int cur = 0;
        foreach(char c in s){
            int next = Search(chars[c-'a'], cur);
            if(next == -1) return false;                                                             cur = next + 1;
        }
        return true;
        
    }
    
    private int Search(List<int> list, int num){
        int left = 0;
        int right = list.Count-1;
        while(left <= right){
            int mid = left + (right - left)/2;
            if(list[mid] == num) return num;
            else if(list[mid] < num) left = mid+1;
            else right = mid - 1;
        }
        if(left < list.Count && list[left] > num) return list[left];
        if(left + 1 < list.Count) return list[left+1];
        return -1;
    }
}

