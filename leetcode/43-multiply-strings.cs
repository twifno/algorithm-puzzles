//https://leetcode.com/problems/multiply-strings/

//Calculated using array.

public class Solution {
    public string Multiply(string num1, string num2) {
        if(num1 == "0" || num2 == "0") return "0";
        int l1 = num1.Length;
        int l2 = num2.Length;
        int[] res = new int[l1+l2];
        for(int i = l1-1; i >= 0; i--){
            int carry = 0;
            int v1 = num1[i] - '0';
            for(int j = l2-1; j >= 0; j--){
                int v2 = num2[j] - '0';
                int mul = v1*v2+carry+res[i+j+1];
                res[i+j+1] = mul % 10;
                carry = mul/10;
            }
            int pos = i - 1;
            while(carry > 0) {
                int val = carry + res[pos+1];
                carry = val / 10;
                res[pos+1] = val % 10;
                pos -= 1;
            }
        }
        return string.Join("", res).TrimStart('0');
    }
}
