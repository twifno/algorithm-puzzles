//https://leetcode.com/problems/complex-number-multiplication/

public class Solution {
    public string ComplexNumberMultiply(string a, string b) {
        int aplus = a.IndexOf('+');
        int a1 = Int32.Parse(a.Substring(0, aplus));
        int a2 = Int32.Parse(a.Substring(aplus+1, a.Length-aplus-2));
        int bplus = b.IndexOf('+');
        int b1 = Int32.Parse(b.Substring(0, bplus));
        int b2 = Int32.Parse(b.Substring(bplus+1, b.Length-bplus-2));
        return (a1*b1-a2*b2).ToString() + "+" + (a1*b2+a2*b1) + "i";
    }
}
