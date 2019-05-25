//https://leetcode.com/problems/flip-game/

public class Solution {
    public IList<string> GeneratePossibleNextMoves(string s) {
        List<string> res = new List<string>();
        char[] cs = s.ToCharArray();
        for(int i = 0; i < cs.Length-1; i++){
            if(cs[i] == '+' && cs[i+1] == '+') {
                cs[i] = '-'; cs[i+1] = '-';
                res.Add(new string(cs));
                cs[i] = '+'; cs[i+1] = '+';
            }
        }
        return res;
    }
}
