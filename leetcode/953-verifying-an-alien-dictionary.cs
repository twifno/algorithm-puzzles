//https://leetcode.com/problems/verifying-an-alien-dictionary/

public class Solution {
    public bool IsAlienSorted(string[] words, string order) {
        int[] dict = new int[26];
        for(int i = 0; i < order.Length; i++) {
            char c = order[i];
            dict[c-'a'] = i;
        }
        for(int i = 0; i < words.Length-1; i++) {
            if(Larger(words[i], words[i+1], dict)) return false;
        }
        return true;
    }
    
    private bool Larger(string w1, string w2, int[] dict){
        for(int i = 0; i < w1.Length; i++){
            if(i >= w2.Length) return true;
            if(dict[w1[i]-'a'] < dict[w2[i]-'a']) return false;
            else if(dict[w1[i]-'a'] > dict[w2[i]-'a']) return true;
        }
        return false;
    }
}
