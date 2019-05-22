//https://leetcode.com/problems/letter-combinations-of-a-phone-number/

//Looping all digits and store in a queue

public class Solution {
    string[] phonebook = {"abc", "def", "ghi", "jkl", "mno", "pqrs", "tuv", "wxyz"};
    public IList<string> LetterCombinations(string digits) {
        Queue<string> q = new Queue<string>();
        if(string.IsNullOrEmpty(digits)) return q.ToList();
        while(q.Count == 0 || q.Peek().Length < digits.Length){
            if(q.Count == 0) {
                char digit = digits[0];
                foreach(char c in phonebook[digit-'2']){
                    q.Enqueue(c.ToString());
                }
            } else {
                string p = q.Dequeue();
                char digit = digits[p.Length];
                foreach(char c in phonebook[digit-'2']){
                    q.Enqueue(p+c);
                }
            }
        }
        return q.ToList();
    }
}
