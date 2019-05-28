//https://leetcode.com/problems/baseball-game/

public class Solution {
    public int CalPoints(string[] ops) {
        Stack<int> rounds = new Stack<int>();
        int sum = 0;
        foreach(string s in ops){
            if(s == "D") {
                int cur = rounds.Peek() * 2;
                sum += cur;
                rounds.Push(cur);
            } else if (s == "+") {
                int last = rounds.Pop();
                int cur = last + rounds.Peek();
                sum += cur;
                rounds.Push(last);
                rounds.Push(cur);
            } else if (s == "C") {
                sum -= rounds.Pop();
            } else {
                int cur = Int32.Parse(s);
                sum += cur;
                rounds.Push(cur);
            }
        }
        return sum;
    }
}
