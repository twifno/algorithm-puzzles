//https://leetcode.com/problems/exclusive-time-of-functions/

public class Solution {
    public int[] ExclusiveTime(int n, IList<string> logs) {
        int[] res = new int[n];
        int cur = 0;
        Stack<int> st = new Stack<int>();
        foreach(string log in logs) {
            string[] tokens = log.Split(':');
            int id = Int32.Parse(tokens[0]);
            bool start = tokens[1] == "start";
            int time = Int32.Parse(tokens[2]);
            if(!start) time += 1;
            if(st.Count == 0) {
                st.Push(id);
                cur = time;
            } else {
                int peek = st.Peek();
                res[peek] += time - cur;
                if(id == peek && !start) st.Pop();
                else st.Push(id);
                cur = time;
            }
        }
        return res;
    }
}
