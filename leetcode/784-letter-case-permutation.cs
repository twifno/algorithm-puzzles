//https://leetcode.com/problems/letter-case-permutation/

public class Solution {
    public IList<string> LetterCasePermutation(string S) {
        List<string> res = new List<string>();
        GetPerm(S.ToCharArray(), 0, res);
        return res;
    }
    
    private void GetPerm(char[] cs, int pos, List<string> res){
        if(pos == cs.Length) res.Add(new string(cs));
        else if(cs[pos] >= 'a' && cs[pos] <= 'z') {
            GetPerm(cs, pos+1, res);
            cs[pos] = char.ToUpper(cs[pos]);
            GetPerm(cs, pos+1, res);
            cs[pos] = char.ToLower(cs[pos]);
        }
        else if(cs[pos] >= 'A' && cs[pos] <= 'Z') {
            GetPerm(cs, pos+1, res);
            cs[pos] = char.ToLower(cs[pos]);
            GetPerm(cs, pos+1, res);
            cs[pos] = char.ToUpper(cs[pos]);
        }
        else GetPerm(cs, pos+1, res);
    }
}
