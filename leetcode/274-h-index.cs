//https://leetcode.com/problems/h-index/

//Bucket sorting

public class Solution {
    public int HIndex(int[] citations) {
        int len = citations.Length;
        int[] buckets = new int[len+1];
        foreach(int c in citations){
            if(c >= len) buckets[len]+=1;
            else buckets[c] += 1;
        }
        int sum = 0;
        for(int i = len; i >= 0; i--){
            sum += buckets[i];
            if(sum >= i) return i;
        }
        return 0;
    }
}
