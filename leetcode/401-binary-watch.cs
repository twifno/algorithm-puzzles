//https://leetcode.com/problems/binary-watch/

public class Solution {
    public IList<string> ReadBinaryWatch(int num) {
        List<string> res = new List<string>();
        for(int i = 0; i < 12; i++){
            for(int j = 0; j < 60; j++) {
                if(CountBits(i) + CountBits(j) == num) {
                    res.Add(string.Format("{0}:{1:D2}", i, j));
                }
            }
        }
        return res;
    }
    
    private int CountBits(int num){
        int count = 0;
        while(num != 0){
            num &= num-1;
            count += 1;
        }
        return count;
    }
}
