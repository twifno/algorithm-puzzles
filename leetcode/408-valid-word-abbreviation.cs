//https://leetcode.com/problems/valid-word-abbreviation/

public class Solution {
    public bool ValidWordAbbreviation(string word, string abbr) {
        int pos1 = 0;
        int pos2 = 0;
        while(pos1 < word.Length || pos2 < abbr.Length){
            if(pos1 == word.Length || pos2 == abbr.Length) return false;
            if(abbr[pos2] >= 'a' && abbr[pos2] <= 'z'){
                if(abbr[pos2] != word[pos1]) return false;
                pos1 += 1;
                pos2 += 1;
            } else {
                if(abbr[pos2] == '0') return false;
                int nlen = 1;
                while(pos2 + nlen < abbr.Length && abbr[pos2+nlen] <= '9') nlen += 1;
                int skips = Int32.Parse(abbr.Substring(pos2, nlen));
                pos2 += nlen;
                pos1 += skips;
                if(pos1 > word.Length) return false;
            }
        }
        return true;
    }
}
