//https://leetcode.com/problems/one-edit-distance/

public class Solution {
    public bool IsOneEditDistance(string word1, string word2) {
        int l1 = word1.Length;
        int l2 = word2.Length;
        if(l1 > l2+1 || l2 > l1+1) return false;
        if(word1 == word2) return false;
        if(l1 < l2) {
            string tmp = word1;
            word1 = word2;
            word2 = tmp;
            l1 = word1.Length;
            l2 = word2.Length;
        }
        int cur = 0;
        while(cur < l2 && word1[cur] == word2[cur]) {
            cur += 1;
        }
        if(cur == l2) return true;
        if(l1 == l2) return word1.Substring(cur+1, l1-cur-1) == word2.Substring(cur+1, l2-cur-1);
        else return word1.Substring(cur+1, l1-cur-1) == word2.Substring(cur, l2-cur);
    }
}
