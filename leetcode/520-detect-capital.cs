//https://leetcode.com/problems/detect-capital/

public class Solution {
    public bool DetectCapitalUse(string word) {
        if(word == word.ToUpper()) return true;
        string tail = word.Substring(1, word.Length-1);
        if(tail == tail.ToLower()) return true;
        return false;
    }
}
