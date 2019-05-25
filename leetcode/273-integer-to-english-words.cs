//https://leetcode.com/problems/integer-to-english-words/

//Be care of zeros

public class Solution {
    public string NumberToWords(int num) {
        if(num == 0) return "Zero";
        string[] b = { "", "Thousand", "Million", "Billion" };
        List<string> tokens = new List<string>();
        int count = 0;
        while(num != 0){
            int next = num % 1000;
            if(next != 0) {
                if(count > 0) tokens.Add(b[count]);
                List<string> nextTokens = UnderThursand(next);
                nextTokens.Reverse();
                tokens.AddRange(nextTokens);
            }
            num = num / 1000;
            count += 1;
        }
        tokens.Reverse();
        return string.Join(" ", tokens);
    }
    
    private List<string> UnderThursand(int num) {
        string[] under20 = { "Zero", "One", "Two", "Three", "Four", "Five", "Six", "Seven", "Eight", "Nine", "Ten", "Eleven", "Twelve", "Thirteen", "Fourteen", "Fifteen", "Sixteen", "Seventeen", "Eighteen", "Nineteen"};
        string[] tens = {"", "", "Twenty", "Thirty", "Forty", "Fifty", "Sixty", "Seventy", "Eighty", "Ninety"};
        List<string> tokens = new List<string>();
        int h = num / 100;
        if(h > 0) {
            tokens.Add(under20[h]);
            tokens.Add("Hundred");
        }
        int t = num % 100;
        if(t > 0 && t < 20) {
            tokens.Add(under20[t]);
        } else
        if(t >= 20) {
            tokens.Add(tens[t/10]);
            int d = t%10;
            if(d > 0) tokens.Add(under20[d]);
        }
        return tokens;
    }
}
