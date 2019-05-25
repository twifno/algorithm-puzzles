//https://leetcode.com/problems/strobogrammatic-number/

//Ask if 1 is strobogrammatic

public class Solution {
    public bool IsStrobogrammatic(string num) {
        if(num.Length == 0) return true;
        char[] nc = num.ToCharArray();
        for(int i = 0; i < nc.Length; i++){
            if(nc[i] == '6') nc[i] = '9';
            else if(nc[i] == '9') nc[i] = '6';
            else if(nc[i] != '8' && nc[i] != '0' && nc[i] != '1') return false;
        }
        if(nc[nc.Length-1] == '0' && nc.Length > 1) return false;
        Array.Reverse(nc);
        string newNum = new string(nc);
        if(newNum == num) return true;
        return false;
    }
}
