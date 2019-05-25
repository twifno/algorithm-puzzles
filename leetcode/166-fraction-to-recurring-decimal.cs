//https://leetcode.com/problems/fraction-to-recurring-decimal/

//Be care of the edge cases.

public class Solution {
    public string FractionToDecimal(int numerator, int denominator) {
        bool neg = numerator > 0 && denominator < 0 || numerator < 0 && denominator > 0;
        string sign = ((neg==true)?"-":"");
        long n = numerator;
        if(n < 0) n = -n;
        long d = denominator;
        if(d < 0) d = -d;
        long q = n / d;
        long r = n % d;
        Dictionary<long, int> dict = new Dictionary<long, int>();
        long[] res = new long[1000];
        int pos = 0;
        StringBuilder sb = new StringBuilder();
        while(r > 0){
            if(dict.ContainsKey(r)){
                int idx = dict[r];
                sb.Append(q);
                sb.Append('.');
                for(int i = 0; i < idx; i++){
                    sb.Append(res[i]);
                }
                sb.Append("(");
                for(int i = idx; i < pos; i++){
                    sb.Append(res[i]);
                }
                sb.Append(")");
                return sign+sb.ToString();
            }
            dict[r] = pos;
            long nq = r*10/d;
            r = r*10%d;
            res[pos] = nq;
            pos += 1;
        }
        sb.Append(q);
        if(pos > 0){
            sb.Append('.');
            for(int i = 0; i < pos; i++) sb.Append(res[i]);
        }
       
        return sign+sb.ToString();
    }
}
