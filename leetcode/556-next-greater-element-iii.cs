//https://leetcode.com/problems/next-greater-element-iii/

public class Solution {
    public int NextGreaterElement(int n) {
        string s = n.ToString();
        char[] cs = s.ToCharArray();
        NextPermutation(cs);
        s = new string(cs);
        int next;
        bool success = Int32.TryParse(s, out next);
        if(!success) return -1;
        if(next <= n) return -1;
        return next;
    }
    
    private void NextPermutation(char[] cs){
        int pos1 = cs.Length - 2;
        while(pos1 >= 0){
            if(cs[pos1] < cs[pos1+1]){
                int pos2 = cs.Length-1;
                while(cs[pos2] <= cs[pos1]) pos2 -= 1;
                Swap(cs, pos1, pos2);
                Array.Sort(cs, pos1+1, cs.Length - pos1 - 1);
                return;
            }
            pos1 -= 1;
        }
    }
    
    private void Swap(char[] cs, int pos1, int pos2){
        char tmp = cs[pos1];
        cs[pos1] = cs[pos2];
        cs[pos2] = tmp;
    }
}
