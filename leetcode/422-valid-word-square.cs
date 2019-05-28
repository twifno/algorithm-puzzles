//https://leetcode.com/problems/valid-word-square/

public class Solution {
    public bool ValidWordSquare(IList<string> words) {
        int len = words.Count;
        for(int i = 0; i < len; i++){
            string word = words[i];
            for(int j = 0; j < word.Length; j++){
                if(j >= len || words[j].Length <= i || word[j] != words[j][i]) return false;
            }
        }
        return true;
    }
}
