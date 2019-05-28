//https://leetcode.com/problems/string-compression/

public class Solution {
    public int Compress(char[] chars) {
        int count = 0;
        int cur = 0;
        int pos = 0;
        while(pos < chars.Length){
            while(pos + count < chars.Length && chars[pos] == chars[pos+count]) count += 1;
            chars[cur] = chars[pos];
            if(count == 1){
                pos += 1;
                cur += 1;
            } else {
                pos += count;
                cur = Append(count, chars, cur+1);
            }
            count = 0;
        }
        return cur;
    }
    
    private int Append(int n, char[] chars, int pos){
        char[] nc = n.ToString().ToCharArray();
        for(int i = 0; i < nc.Length; i++){
            chars[pos] = nc[i];
            pos += 1;
        }
        return pos;
    }
}
