//https://leetcode.com/problems/sort-characters-by-frequency/

//Count the characters

public class Solution {
    class CharCount {
        public char Character;
        public int Count;
        public CharCount(int count, char c){
            Character = c;
            Count = count;
        }
    }
        
    public string FrequencySort(string s) {
        Dictionary<char, CharCount> map = new Dictionary<char, CharCount>();
        foreach(char c in s){
            if(!map.ContainsKey(c)) map[c] = new CharCount(1, c);
            else map[c].Count += 1;
        }
        List<CharCount> list = new List<CharCount>(map.Values);
        list.Sort((x, y) => y.Count.CompareTo(x.Count));
        StringBuilder sb = new StringBuilder();
        foreach(CharCount cc in list){
            for(int i = 0; i < cc.Count; i++) sb.Append(cc.Character);
        }
        return sb.ToString();
    }
}
