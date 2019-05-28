//https://leetcode.com/problems/find-the-closest-palindrome/

//Case by case. Find the larger one, then find the smaller one, then compare.

public class Solution {
    public string NearestPalindromic(string n) {
        string s = FindSmaller(n);
        string l = FindLarger(n);
        if(s == "") return l;
        long nn = Int64.Parse(n);
        long sn = Int64.Parse(s);
        long ln = Int64.Parse(l);
        if(ln - nn < nn - sn) return l;
        return s;
    }
    
    private string FindSmaller(string n){
        if(n == "0") return "";
        if(n == "1") return "0";
        int len = n.Length;
        char[] nc = n.ToCharArray();
        int left = 0;
        int right = len-1;
        while(left < right){
            nc[right--] = nc[left++];
        }
        if((new string(nc)).CompareTo(n) < 0) return new string(nc);
        int mid = (len-1)/2;
        for(int i = mid; i >= 0; i--){
            if(i > 0 && nc[i] > '0' || nc[i] > '1') {
                nc[i] = (char)(nc[i] - 1);
                if(len % 2 == 1){
                    nc[2*mid-i] = nc[i];
                } else {
                    nc[2*mid-i+1] = nc[i];
                }
                return new string(nc);
            }
        }
        return new string('9', len-1);
    }
    
    private string FindLarger(string n) {
        int len = n.Length;
        char[] nc = n.ToCharArray();
        int left = 0;
        int right = len-1;
        while(left < right){
            nc[right--] = nc[left++];
        }
        if((new string(nc)).CompareTo(n) > 0) return new string(nc);
        int mid = (len-1)/2;
        for(int i = mid; i >= 0; i--){
            if(nc[i] < '9') {
                nc[i] = (char)(nc[i] + 1);
                if(len % 2 == 1){
                    nc[2*mid-i] = nc[i];
                } else {
                    nc[2*mid-i+1] = nc[i];
                }
                return new string(nc);
            }
        }
        return "1"+(new string('0', len-1))+"1";
    }
}
