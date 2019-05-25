//https://leetcode.com/problems/encode-and-decode-strings/

public class Codec {

    // Encodes a list of strings to a single string.
    public string encode(IList<string> strs) {
        StringBuilder sb = new StringBuilder();
        foreach(string s in strs){
            sb.Append(s.Length+":"+s);
        }
        return sb.ToString();
    }

    // Decodes a single string to a list of strings.
    public IList<string> decode(string s) {
        //System.Console.WriteLine(s);
        List<string> res = new List<string>();
        if(s == "") return res;
        int cur = 0;
        while(cur < s.Length){
            int index = s.IndexOf(':', cur);
            //System.Console.WriteLine(Int32.Parse(s.Substring(cur, index)));
            int len = Int32.Parse(s.Substring(cur, index-cur));
            res.Add(s.Substring(index+1, len));
            cur = index + len + 1;
        }
        return res;
    }
}

// Your Codec object will be instantiated and called as such:
// Codec codec = new Codec();
// codec.decode(codec.encode(strs));
