//https://leetcode.com/problems/jewels-and-stones/

public class Solution {
    public int NumJewelsInStones(string J, string S) {
        HashSet<char> hs = new HashSet<char>();
        foreach(char c in J) hs.Add(c);
        int count = 0;
        foreach(char c in S) if(hs.Contains(c)) count += 1;
        return count; 
    }
}
