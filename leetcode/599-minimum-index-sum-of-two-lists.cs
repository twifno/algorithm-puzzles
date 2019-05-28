//https://leetcode.com/problems/range-addition-ii/

public class Solution {
    public string[] FindRestaurant(string[] list1, string[] list2) {
        Dictionary<string, int> rank = new Dictionary<string, int>();
        for(int i = 0; i < list1.Length; i++) rank[list1[i]] = i;
        int min = Int32.MaxValue;
        List<string> res = new List<string>();
        for(int i = 0; i < list2.Length; i++) {
            if(rank.ContainsKey(list2[i])) {
                int tr = rank[list2[i]] + i;
                if(min > tr) {
                    min = tr;
                    res.Clear();
                    res.Add(list2[i]);
                } else if(min == tr) res.Add(list2[i]);
            }
        }
        return res.ToArray();
    }
}
