//https://leetcode.com/problems/utf-8-validation/

//Bit masking…

public class Solution {
    public bool ValidUtf8(int[] data) {
        int remain = 0;
        for(int i = 0; i < data.Length; i++){
            int d = data[i];
            if(remain == 0){
                if((d & 0XF8) == 0XF0) remain = 3;
                else if((d & 0XF0) == 0XE0) remain = 2;
                else if((d & 0XE0) == 0XC0) remain = 1;
                else if((d & 0X80) == 0) remain = 0;
                else return false;
            } else {
                if((d & 0XC0) == 0X80) remain -= 1;
                else return false;
            }
        }
        if(remain == 0) return true;
        return false;
    }
}
