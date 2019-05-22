//https://leetcode.com/problems/gray-code/

//Need to run backwards after adding one most significant bit.

public class Solution {
    public IList<int> GrayCode(int n) {
        List<int> res = new List<int>();
        res.Add(0);
        int b = 1;
        for(int i = 1; i <=n; i++){
            for(int j = res.Count-1; j >=0; j--) res.Add(b + res[j]);
            b *= 2;
        }
        return res;
    }
}

//Another idea: G(i) = I ^ (i/2) - why?

