//https://leetcode.com/problems/read-n-characters-given-read4/

/**
 * The Read4 API is defined in the parent class Reader4.
 *     int Read4(char[] buf);
 */
public class Solution : Reader4 {
    /**
     * @param buf Destination buffer
     * @param n   Number of characters to read
     * @return    The number of actual characters read
     */
    public int Read(char[] buf, int n) {
        int count = 0;
        char[] buf4 = new char[4];
        while(count < n){
            int rc = Read4(buf4);
            if(n - count < rc){
                for(int i = 0; i < n-count; i++){
                    buf[count+i] = buf4[i];  
                }
                return n;
            } else {
                for(int i = 0; i < rc; i++){
                    buf[count+i] = buf4[i];
                }
                if(rc < 4) return count + rc;
            }
            count += rc;
        }
        return count;
    }
}
