//https://leetcode.com/problems/smallest-range/

public class Solution {
    class Num: IComparable<Num> {
        public int Val;
        public int Pos;
        public int Rank;
        public Num(int v, int p, int r){
            Val = v;
            Pos = p;
            Rank = r;
        }
        public int CompareTo(Num n) {
            if(Val != n.Val) return Val.CompareTo(n.Val);
            return GetHashCode().CompareTo(n.GetHashCode());
        }
    }
    
    public int[] SmallestRange(IList<IList<int>> nums) {
        int min = Int32.MaxValue;
        int last = Int32.MinValue;
        SortedSet<Num> ss = new SortedSet<Num>();
        for(int i = 0; i < nums.Count; i++) {
            ss.Add(new Num(nums[i][0], i, 0));
            last = Math.Max(last, nums[i][0]);
        }
        int mfirst = 0;
        int mlast = 0;
        while(true) {
            Num first = ss.First();
            if(min > last - first.Val + 1){
                mfirst = first.Val;
                mlast = last;
                min = mlast - mfirst + 1;
            }
            if(nums[first.Pos].Count == first.Rank+1) break;
            ss.Remove(first);
            Num next = new Num(nums[first.Pos][first.Rank+1], first.Pos, first.Rank+1);
            last = Math.Max(last, next.Val);
            ss.Add(next);
        }
        return new int[2] { mfirst, mlast};
    }
}
