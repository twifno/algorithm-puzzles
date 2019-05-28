//https://leetcode.com/problems/remove-k-digits/

//Greedy
//When there is an opportunity for a smaller number to take the more significant position, go for it.


public class Solution {
    public string RemoveKdigits(string num, int k) {
        Stack<char> st = new Stack<char>();
        int count = 0;
        foreach(char c in num){
            while(count < k && st.Count > 0 && st.Peek() > c) {
                st.Pop();
                count += 1;
            }
            st.Push(c);
        }
        while(count < k){
            st.Pop();
            count += 1;
        }
        char[] newNum = st.ToArray();
        Array.Reverse(newNum);
        string nN = new string(newNum);
        nN = nN.TrimStart('0');
        if(nN == "") nN = "0";
        return nN;
    }
}
