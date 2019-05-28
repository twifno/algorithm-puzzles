//https://leetcode.com/problems/ternary-expression-parser/

//Trick: Find the last ":" with no paired "?"

public class Solution {
    public string ParseTernary(string expression) {
        if(expression.IndexOf('?') == -1) return expression;
        int count = 0;
        int pos = 0;
        for(int i = 2; i < expression.Length; i++){
            if(expression[i] == '?') count += 1;
            else if(expression[i] == ':'){
                if(count == 0) {
                    pos = i;
                    break;
                }else{
                    count -= 1;
                }
            }
        }
        System.Console.WriteLine(pos);
        if(expression[0] == 'T') return ParseTernary(expression.Substring(2, pos-2));
        else return ParseTernary(expression.Substring(pos+1, expression.Length-pos-1));
    }
}
