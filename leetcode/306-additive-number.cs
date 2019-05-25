//https://leetcode.com/problems/additive-number/

//Be care of number overflow.

public class Solution {
    public bool IsAdditiveNumber(string num) {
        if(num.Length == 0) return true;
        for(int i = 0; i < num.Length/2; i++){
            if(num[0] == '0' && i > 0) break;
            for(int j = i+1; j < num.Length-1; j++){
                if(num[i+1] == '0' && j > i+1) break;
                string n1 = num.Substring(0, i+1);
                string n2 = num.Substring(i+1, j-i);
                if(IsAdditiveNumber(n1, n2, num.Substring(j+1, num.Length-j-1))) return true;
            }
        }
        return false;
    }
    
    private bool IsAdditiveNumber(string n1, string n2, string num){
        if(num.Length == 0) return true;
        string n3 = Add(n1, n2);
        if(num.IndexOf(n3) != 0) return false;
        return IsAdditiveNumber(n2, n3, num.Substring(n3.Length, num.Length-n3.Length));
    }
    
    private string Add(string n1, string n2){
        int carry = 0;
        int l1 = n1.Length-1;
        int l2 = n2.Length-1;
        StringBuilder sb = new StringBuilder();
        while(l1 >= 0 || l2 >= 0) {
            int val = carry;
            if(l1 >= 0){
                val += n1[l1] - '0';
                l1 -= 1;
            } 
            if(l2 >= 0){
                val += n2[l2] - '0';
                l2 -= 1;
            }
            sb.Insert(0, val%10);
            carry = val/10;
        }
        if(carry > 0) sb.Insert(0, carry);
        return sb.ToString();
    }
}
