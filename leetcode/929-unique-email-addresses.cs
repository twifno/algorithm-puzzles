//https://leetcode.com/problems/unique-email-addresses/

public class Solution {
    public int NumUniqueEmails(string[] emails) {
        HashSet<string> hs = new HashSet<string>();
        foreach(string email in emails){
            int at = email.IndexOf('@');
            string name = email.Substring(0, at);
            name = name.Replace(".", "");
            int plus = name.IndexOf('+');
            string  domain = email.Substring(at, email.Length-at);
            if(plus != -1) name = name.Substring(0, plus);
            hs.Add(name + domain);
        }
        return hs.Count;
    }
}
