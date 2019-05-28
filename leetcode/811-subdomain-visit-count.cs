//https://leetcode.com/problems/subdomain-visit-count/

public class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        Dictionary<string, int> counts = new Dictionary<string, int>();
        foreach(string p in cpdomains){
            string[] tokens = p.Split(" ");
            int count = Int32.Parse(tokens[0]);
            string domain = tokens[1];
            while(domain != ""){
                if(!counts.ContainsKey(domain)) counts[domain] = count;
                else counts[domain] += count;
                int dot = domain.IndexOf('.');
                if(dot == -1) break;
                domain = domain.Substring(dot+1, domain.Length-dot-1);
            }
        }
        List<string> res = new List<string>();
        foreach(string k in counts.Keys){
            res.Add(counts[k] + " " + k);
        }
        return res;
    }
}
