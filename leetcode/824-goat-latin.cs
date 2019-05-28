//https://leetcode.com/problems/goat-latin/

public class Solution {
    public string ToGoatLatin(string S) {
        HashSet<char> vowels = new HashSet<char>(new char[]{'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U'});
        string[] ss = S.Split();
        for(int i = 0; i < ss.Length; i++){
            StringBuilder sb = new StringBuilder();
            string s = ss[i];
            if(vowels.Contains(s[0])) sb.Append(s);
            else {
                sb.Append(s.Substring(1, s.Length-1));
                sb.Append(s[0]);
            }
            sb.Append("ma");
            sb.Append(new string('a', i+1));
            ss[i] = sb.ToString();
        }
        return string.Join(" ", ss);
    }
}
