//https://leetcode.com/problems/expression-add-operators/

//Save the last operand,
//Be care of 0

public class Solution {
    public IList<string> AddOperators(string num, int target) {
        List<string> res = new List<string>();
        List<string> path = new List<string>();
        Dfs(0, 0, 0, num, target, res, path);
        return res;
    }
    
    private void Dfs(int cur, long val, long last, string num, int target, List<string> res, List<string> path){
        string[] ops = { "+", "-", "*" };
        if(cur == num.Length) {
            if(val == target) res.Add(string.Join("", path));
            return;
        }
        if(cur == 0) {
            for(int i = cur; i < num.Length; i++) {
                string next = num.Substring(cur, i-cur+1);
                long v = Int64.Parse(next);
                path.Add(next);
                Dfs(i+1, v, v, num, target, res, path);
                path.RemoveAt(path.Count-1);
                if(num[cur] == '0') break;
            }
        } else {
            for(int i = cur; i < num.Length; i++) {
                string next = num.Substring(cur, i-cur+1);
                long v = Int64.Parse(next);
                foreach(string op in ops){
                    path.Add(op);
                    path.Add(next);
                    if(op == "+") Dfs(i+1, val+v, v, num, target, res, path);
                    if(op == "-") Dfs(i+1, val-v, -v, num, target, res, path);
                    if(op == "*") Dfs(i+1, val-last+last*v, last*v, num, target, res, path);
                    path.RemoveAt(path.Count-1);
                    path.RemoveAt(path.Count-1);
                }
                if(num[cur] == '0') break;
            }
        }
    }
}
