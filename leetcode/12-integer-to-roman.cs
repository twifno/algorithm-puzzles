//https://leetcode.com/problems/integer-to-roman/

//Case by case approach

public class Solution {
    public string IntToRoman(int num) {
        StringBuilder sb = new StringBuilder();
        while(num >= 1000){
            sb.Append("M");
            num -= 1000;
        }
        if(num >= 900){
            sb.Append("CM");
            num -= 900;
        }
        if(num >= 500){
            sb.Append("D");
            num -= 500;
        }
        if(num >= 400){
            sb.Append("CD");
            num -= 400;
        }
        while(num >= 100){
            sb.Append("C");
            num -= 100;
        }
        if(num >= 90){
            sb.Append("XC");
            num -= 90;
        }
        if(num >= 50){
            sb.Append("L");
            num -= 50;
        }
        if(num >= 40){
            sb.Append("XL");
            num -= 40;
        }
        while(num >= 10){
            sb.Append("X");
            num -= 10;
        }
        if(num >= 9){
            sb.Append("IX");
            num -= 9;
        }
        if(num >= 5){
            sb.Append("V");
            num -= 5;
        }
        if(num >= 4){
            sb.Append("IV");
            num -= 4;
        }
        while(num >= 1){
            sb.Append("I");
            num -= 1;
        }
        return sb.ToString();
    }
}
