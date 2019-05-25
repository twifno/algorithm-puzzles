//https://leetcode.com/problems/find-k-pairs-with-smallest-sums/

//Priority Queue

public class Solution {
    class Pair{
        public int X;
        public int Y;
        public int Rank1;
        public int Rank2;
        public Pair(int x, int y, int r1, int r2) {
            X = x;
            Y = y;
            Rank1 = r1;
            Rank2 = r2;
        }
    }
    
    class PairComparer : IComparer<Pair>
    {
        public int Compare(Pair p1, Pair p2){
            if(p1.X+p1.Y == p2.X+p2.Y) {
                if(p1.Rank1 == p2.Rank1) return p1.Rank2.CompareTo(p2.Rank2);
                return p1.Rank1.CompareTo(p2.Rank1);
            }
            return (p1.X+p1.Y).CompareTo(p2.X+p2.Y);
        }
    }
    
    public IList<int[]> KSmallestPairs(int[] nums1, int[] nums2, int k) {
        SortedSet<Pair> q = new SortedSet<Pair>(new PairComparer());
        IList<int[]> res = new List<int[]>();
        if(nums1.Length == 0 || nums2.Length == 0) return res;
        for(int i = 0; i < nums1.Length && i < k; i++){
            q.Add(new Pair(nums1[i], nums2[0], i, 0));
        }
        int count = 0;
        while(q.Count > 0 && count < k){
            Pair p = q.First();
            res.Add(new int[2] {p.X, p.Y});
            if(p.Rank2 < nums2.Length-1){
                q.Add(new Pair(p.X, nums2[p.Rank2+1], p.Rank1, p.Rank2+1));
            }
            q.Remove(p);
            count += 1;
        }
        return res;
    }
}
