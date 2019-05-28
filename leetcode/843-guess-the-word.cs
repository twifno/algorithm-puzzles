//https://leetcode.com/problems/guess-the-word/

//Min Max worst case;

/**
 * // This is the Master's API interface.
 * // You should not implement it, or speculate about its implementation
 * class Master {
 *     public int Guess(string word);
 * }
 */
class Solution {
    public void FindSecretWord(string[] wordlist, Master master) {
        int len = wordlist.Length;
        int[,] counts = new int[len, len];
        for(int i = 0; i < len; i++){
            for(int j = 0; j < len; j++){
                counts[i, j] = Match(wordlist[i], wordlist[j]);
            }
        }
        List<int> candidates = new List<int>();
        for(int i = 0; i < len; i++) candidates.Add(i);
        int t = 10;
        while(t-- > 0) {
            int next = Next(candidates, counts);
            int guess = master.Guess(wordlist[next]);
            if(guess == 6) return;
            candidates = Update(candidates, next, guess, counts);
        }
    }
    
    private int Next(List<int> candidates, int[,] counts) {
        int min = Int32.MaxValue;
        int next = -1;
        foreach(int c in candidates){
            int[] g = new int[7];
            foreach(int o in candidates) {
                if(o != c) g[counts[c, o]] += 1;
            }
            int max = 0;
            foreach(int n in g) max = Math.Max(max, n);
            if(min > max) {
                min = max;
                next = c;
            }
        }
        return next;
    }
    
    private List<int> Update(List<int> candidates, int cur, int guess, int[,] counts){
        List<int> res = new List<int>();
        foreach(int c in candidates){
            if(c != cur && counts[c, cur] == guess) res.Add(c);
        }
        return res;
    }
    
    private int Match(string w1, string w2) {
        int count = 0;
        for(int i = 0; i < w1.Length; i++) if(w1[i] == w2[i]) count += 1;
        return count;
    }
}
