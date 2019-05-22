//https://leetcode.com/problems/group-anagrams/

//Categorized by sorted string

public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        Dictionary<string, IList<string>> dict = new Dictionary<string, IList<string>>();
        foreach(string s in strs){
            char[] characters = s.ToArray();
            Array.Sort(characters);
            string k = new string(characters);
            if(dict.ContainsKey(k)) dict[k].Add(s);
            else {
                dict[k] = new List<string>();
                dict[k].Add(s);
            }
        }
        return dict.Values.ToList();
    }
}
