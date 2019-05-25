//https://leetcode.com/problems/h-index-ii/

public class Solution {
    public int HIndex(int[] citations) {
        int len = citations.Length;
        for(int i = len-1; i >= 0; i--){
            //System.Console.WriteLine(citations[i]);
            if(len - i > citations[i]) return len-i-1;
            if(len - i >= citations[i]) return citations[i];
        }
        return len;
    }
}


//Better solution
class Solution {
    public int hIndex(int[] citations) {
        int ans = citations.length;
        for(int c : citations) {
            if(c >= ans) break;
            --ans;
        }   
        return ans;
    }   
}
