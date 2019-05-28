//https://leetcode.com/problems/add-strings/

public class Solution {
    public string AddStrings(string num1, string num2) {
        char[] nc1 = num1.ToCharArray();
        char[] nc2 = num2.ToCharArray();
        Array.Reverse(nc1);
        Array.Reverse(nc2);
        List<int> sum = new List<int>();
        int carry = 0;
        int cur = 0;
        while(cur < nc1.Length || cur < nc2.Length){
            int digitSum = carry;
            if(nc1.Length > cur) digitSum += nc1[cur] - '0';
            if(nc2.Length > cur) digitSum += nc2[cur] - '0';
            carry = digitSum / 10;
            sum.Add(digitSum % 10);
            cur += 1;
        }
        if(carry > 0) sum.Add(carry);
        sum.Reverse();
        return string.Join("", sum);
    }
}
