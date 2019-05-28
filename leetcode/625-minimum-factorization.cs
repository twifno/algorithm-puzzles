//https://leetcode.com/problems/minimum-factorization/

//Be care of overflow.

public class Solution {
    public int SmallestFactorization(int a) {
        if(a == 1) return 1;
        List<int> bs = new List<int>();
        int cur = 9;
        while(cur > 1){
            if(a % cur == 0) {
                bs.Add(cur);
                a /= cur;
            } else {
                cur -= 1;
            }
        }
        if(a != 1) return 0;
        bs.Sort();
        int b = 0;
        foreach(int n in bs){
            if(b * 10 / 10 != b || b*10+n-n != b*10) return 0;
            b = b * 10 + n;
        }
        return b;
    }
}
