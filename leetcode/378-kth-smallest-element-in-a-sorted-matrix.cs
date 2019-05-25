//https://leetcode.com/problems/kth-smallest-element-in-a-sorted-matrix/

public class Solution {
    class Num {
        public int Val;
        public int Pos;
        public int Rank;
        public Num(int v, int p, int r) {
            Val = v;
            Pos = p;
            Rank = r;
        }
    }
    
    class NumComparer:IComparer<Num> {
        public int Compare(Num n1, Num n2){
            if(n1.Val == n2.Val){
                return n1.GetHashCode().CompareTo(n2.GetHashCode());
            }
            return n1.Val.CompareTo(n2.Val);
        }
    }
    
    public int KthSmallest(int[][] matrix, int k) {
        SortedSet<Num> q = new SortedSet<Num>(new NumComparer());
        for(int i = 0; i < matrix.Length && i < k; i++){
            q.Add(new Num(matrix[i][0], i, 0));
        }
        for(int i = 0; i < k; i++){
            if(k == i+1) return q.First().Val;
            Num first = q.First();
            q.Remove(q.First());
            if(first.Rank < matrix[0].Length-1){
                q.Add(new Num(matrix[first.Pos][first.Rank+1], first.Pos, first.Rank+1));
            }
        }
        return 0;
    }
}
