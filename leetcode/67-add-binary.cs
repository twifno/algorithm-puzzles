//https://leetcode.com/problems/add-binary/

//It is easier to convert each bit to number for calculation.

public class Solution {
    public string AddBinary(string a, string b) {
        int p1 = a.Length-1;
        int p2 = b.Length-1;
        StringBuilder sb = new StringBuilder();
        int carry = 0;
        while(p1 >= 0 || p2 >= 0){
            if(p1 < 0){
                int sum = (b[p2] - '0') + carry;
                sb.Insert(0, sum%2);
                carry = sum/2;
                p2 -= 1;
            } else if(p2 < 0){
                int sum = (a[p1] - '0') + carry;
                sb.Insert(0, sum%2);
                carry = sum/2;
                p1 -= 1;
            } else {
                int sum = (a[p1] - '0') + (b[p2] - '0') + carry;
                sb.Insert(0, sum%2);
                carry = sum/2;
                p1 -= 1;
                p2 -= 1;
            }
        }
        if(carry == 1) sb.Insert(0, '1');
        return sb.ToString();
    }
}
