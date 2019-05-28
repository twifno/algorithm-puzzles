//https://leetcode.com/problems/convert-a-number-to-hexadecimal/

//Shift on unsigned number num = (int)((uint)num >> 4);

public class Solution {
    public string ToHex(int num) {
        char[] map = {'0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'a', 'b', 'c', 'd', 'e', 'f'};
        if(num == 0) return "0";
        StringBuilder sb = new StringBuilder();
        while(num != 0){
            sb.Insert(0, map[num & 15]);
            num = (int)((uint)num >> 4);
        }
        return sb.ToString().TrimStart('0');
    }
}
