//https://leetcode.com/problems/shortest-completing-word/

//Not the most efficient solution, can just compare each string and keep the one with minimum length.

public class Solution {
    class Word {
        public string Val;
        public int[] Counts;
        public int Pos;
        public Word(string v, int p){
            Val = v;
            string lower = Val.ToLower();
            Counts = new int[26];
            foreach(char c in lower){
                Counts[c-'a'] += 1;
            }
            Pos = p;
        }
        public bool Contains(int[] others){
            for(int i = 0; i < 26; i++) if(others[i] > Counts[i]) return false;
            return true;
        }
    }
    
    public string ShortestCompletingWord(string licensePlate, string[] words) {
        Word[] ws = new Word[words.Length];
        for(int i = 0; i < words.Length; i++){
            ws[i] = new Word(words[i], i);
        }
        Array.Sort(ws, delegate(Word w1, Word w2) {
           if(w1.Val.Length != w2.Val.Length) return w1.Val.Length.CompareTo(w2.Val.Length);
            return w1.Pos.CompareTo(w2.Pos);
        });
        int[] counts = new int[26];
        string lower = licensePlate.ToLower();
        foreach(char c in lower){
            if(c < 'a' || c > 'z') continue;
            counts[c-'a'] += 1;
        }
        for(int i = 0; i < ws.Length; i++){
            if(ws[i].Contains(counts)) return ws[i].Val;
        }
        return "";
    }
}
