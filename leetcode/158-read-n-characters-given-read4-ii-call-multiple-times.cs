//https://leetcode.com/problems/read-n-characters-given-read4-ii-call-multiple-times/

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
    char[] remains = new char[4];
    int r = 0;
    
    public int Read(char[] buf, int n) {
        //System.Console.WriteLine(r);
        //System.Console.WriteLine(remains[0]);
        int count = 0;
        if(n >= r) {
            for(int i = 0; i < r; i++) buf[i] = remains[i];
            count = r;
            r = 0;
        } else {
            for(int i = 0; i < n; i++){
                buf[i] = remains[i];  
            }
            for(int i = 0; i < r-n; i++){
                remains[i] = remains[i+n]; 
            }
            r = r-n;
            return n;
        }
        //System.Console.WriteLine(count);
        char[] buf4 = new char[4];
        while(count < n){
            int rc = Read4(buf4);
            if(n - count < rc){
                for(int i = 0; i < n-count; i++){
                    buf[count+i] = buf4[i];  
                }
                for(int i = 0; i < rc-n+count; i++){
                    remains[i] = buf4[i+n-count];   
                }
                r = rc-n+count;
                return n;
            } else {
                for(int i = 0; i < rc; i++){
                    buf[count+i] = buf4[i];
                }
                if(rc < 4) return count + rc;
            }
            count += rc;
        }
        //System.Console.WriteLine(count);
        return count;
    }
}
