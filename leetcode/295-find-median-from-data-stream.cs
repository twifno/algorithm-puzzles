//https://leetcode.com/problems/find-median-from-data-stream/

//2 Heap

public class MedianFinder {

    class Num: IComparable<Num> {
        public int Val;
        public Num(int v) {
            Val = v;
        }
        public int CompareTo(Num o){
            if(Val != o.Val) return Val.CompareTo(o.Val);
            return GetHashCode().CompareTo(o.GetHashCode());
        }
    }
    
    SortedSet<Num> Large;
    SortedSet<Num> Small;
    
    /** initialize your data structure here. */
    public MedianFinder() {
        Large = new SortedSet<Num>();
        Small = new SortedSet<Num>();
    }
    
    public void AddNum(int num) {
        if(Large.Count == 0) Large.Add(new Num(num));
        else if(num >= Large.Min.Val) Large.Add(new Num(num));
        else Small.Add(new Num(num));
        if(Large.Count >= Small.Count + 2) {
            Num n = Large.Min;
            Small.Add(n);
            Large.Remove(n);
        } else if(Large.Count < Small.Count) {
            Num n = Small.Max;
            Large.Add(n);
            Small.Remove(n);
        }
    }
    
    public double FindMedian() {
        if(Large.Count == 0) return 0;
        else if(Large.Count > Small.Count) return Large.Min.Val;
        return (Large.Min.Val + Small.Max.Val)/2.0;
    }
}

/**
 * Your MedianFinder object will be instantiated and called as such:
 * MedianFinder obj = new MedianFinder();
 * obj.AddNum(num);
 * double param_2 = obj.FindMedian();
 */
