//https://leetcode.com/problems/unique-word-abbreviation/

public class ValidWordAbbr {

    Dictionary<string, string> dict = new Dictionary<string, string>();
    
    private string ToAbbr(string s){
        if(s.Length <= 2) return s;
        StringBuilder sb = new StringBuilder();
        sb.Append(s[0]);
        sb.Append(s.Length-2);
        sb.Append(s[s.Length-1]);
        return sb.ToString();
    }
    
    public ValidWordAbbr(string[] dictionary) {
        foreach(string s in dictionary){
            string abbr = ToAbbr(s);
            if(dict.ContainsKey(abbr)){if(dict[abbr] != s) dict[abbr] = "";}
            else dict[abbr] = s;
        }
    }
    
    public bool IsUnique(string word) {
        string abbr = ToAbbr(word);
        if(dict.ContainsKey(abbr)) {
            if(dict[abbr] == word) return true;
            else return false;
        }
        return true;
    }
}

/**
 * Your ValidWordAbbr object will be instantiated and called as such:
 * ValidWordAbbr obj = new ValidWordAbbr(dictionary);
 * bool param_1 = obj.IsUnique(word);
 */
