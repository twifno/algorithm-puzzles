//https://leetcode.com/problems/random-pick-with-blacklist/

//Do not move the number in the >= N-Size range.

public class Solution {

    int N;
    int Size;
    Dictionary<int, int> Map;
    Random Rand;
    
    public Solution(int N, int[] blacklist) {
        this.N = N;
        Map = new Dictionary<int, int>();
        Array.Sort(blacklist, (x, y) => y.CompareTo(x));
        int cur = N-1;
        Size = blacklist.Length;
        for(int i = 0; i < blacklist.Length; i++){
            if(blacklist[i] >= N-Size) {
                Map[blacklist[i]] = blacklist[i];
                continue;
            }
            while(Map.ContainsKey(cur)) cur -= 1;
            Map[blacklist[i]] = cur;
            cur -= 1;
        }
        Rand = new Random();
        //foreach(int k in Map.Keys) System.Console.WriteLine(k + ":" + Map[k]);
    }
    
    public int Pick() {
        int next = Rand.Next(N - Size);
        if(Map.ContainsKey(next)) return Map[next];
        else return next;
    }
}

/**
 * Your Solution object will be instantiated and called as such:
 * Solution obj = new Solution(N, blacklist);
 * int param_1 = obj.Pick();
 */
