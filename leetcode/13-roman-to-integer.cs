//https://leetcode.com/problems/roman-to-integer/

//Similar to integer to Roman, make a case by case approach, save the case in a array to make the code more clear.

public class Solution {
    string[] romans = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I"};
    int[] nums = { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1};
    public int RomanToInt(string s) {
        int num = 0;
        int cur = 0;
        for(int i = 0; i < romans.Length; i++){
            while(s.IndexOf(romans[i], cur) == cur){
                cur += romans[i].Length;
                num += nums[i];
            }
        }
        return num;
    }
}
