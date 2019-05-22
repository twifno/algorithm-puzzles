//https://leetcode.com/problems/count-and-say/

//Just construction the seq based on the rule one by one.

public class Solution {
    public string CountAndSay(int n) {
        string[] says = new string[30];
        says[0] = "1";
        for(int i = 1; i < n; i++){
            string pre = says[i-1];
            int count = 1;
            int cur = 0;
            StringBuilder sb = new StringBuilder();
            while(cur < pre.Length){
                if(cur+1 == pre.Length){
                    sb.Append(count);
                    sb.Append(pre[cur]);
                } else if(pre[cur] != pre[cur+1]){
                    sb.Append(count);
                    sb.Append(pre[cur]);
                    count = 1;
                } else {
                    count += 1;
                }
                cur += 1;
            }
            says[i] = sb.ToString();
        }
        return says[n-1];
    }
}
