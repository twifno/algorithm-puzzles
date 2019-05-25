//https://leetcode.com/problems/repeated-dna-sequences/

//Solved by utilizing hash table, how to control the space complexity?

public class Solution {
    public IList<string> FindRepeatedDnaSequences(string s) {
        HashSet<string> hs = new HashSet<string>();
        HashSet<string> res = new HashSet<string>();
        for(int i = 0; i < s.Length-9; i++){
            string sub = s.Substring(i, 10);
            if(hs.Contains(sub)) res.Add(sub);
            else hs.Add(sub);
        }
        return res.ToList();
    }
}
