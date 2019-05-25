//https://leetcode.com/problems/shortest-word-distance-iii/

public class Solution {
    public int ShortestWordDistance(string[] words, string word1, string word2) {
        int l1 = -1;
        int l2 = -1;
        int min = Int32.MaxValue;
        for(int i = 0; i < words.Length; i++){
            if(word1 == words[i]) {
                l1 = i;
                if(l2 != -1) min = Math.Min(l1-l2, min);
                if(word1 == word2) l2 = i;
            } else if(word2 == words[i]) {
                l2 = i;
                if(l1 != -1) min = Math.Min(l2-l1, min);
                if(word1 == word2) l2 = i;
            }
        }
        return min;
    }
}
