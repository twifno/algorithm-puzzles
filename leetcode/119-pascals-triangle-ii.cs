//https://leetcode.com/problems/pascals-triangle-ii/

public class Solution {
    public IList<int> GetRow(int rowIndex) {
        List<int> res = new List<int>();
        for(int i = 0; i <= rowIndex; i++){
            for(int j = res.Count-1; j > 0; j--){
                res[j] = res[j] + res[j-1];
            }
            res.Add(1);
        }
        return res;
    }
}
