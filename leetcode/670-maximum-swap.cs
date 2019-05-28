//https://leetcode.com/problems/maximum-swap/

public class Solution {
    public int MaximumSwap(int num) {
        char[] nc = num.ToString().ToCharArray();
        char[] snc = num.ToString().ToCharArray();
        Array.Sort(snc, (x,y) => y.CompareTo(x));
        int p1 = 0;
        while(p1 < nc.Length && nc[p1] == snc[p1]) p1 += 1;
        if(p1 == nc.Length) return num;
        int p2 = nc.Length - 1;
        while(p2 >= 0 && nc[p2] != snc[p1]) p2 -= 1;
        char tmp = nc[p1];
        nc[p1] = nc[p2];
        nc[p2] = tmp;
        return Int32.Parse(new string(nc));
    }
}
