//https://leetcode.com/problems/sliding-window-median/

//2 Heap - be care of overflow

public class Solution {
    public double[] MedianSlidingWindow(int[] nums, int k) {
        Large = new SortedSet<Num>();
        Small = new SortedSet<Num>();
        int len = nums.Length;
        if(len == 0 || k == 0) return new double[0]{};
        double[] res = new double[len-k+1];
        for(int i = 0; i < k-1; i++) { AddNum(nums[i], i); }
        for(int i = k-1; i < len; i++) {
            AddNum(nums[i], i);
            res[i-k+1] = FindMedian();
            RemoveNum(nums[i-k+1], i-k+1);
        }
        return res;
    }
    
    class Num: IComparable<Num> {
        public int Val;
        public int Id;
        public Num(int v, int id) {
            Val = v;
            Id = id;
        }
        public int CompareTo(Num o){
            if(Val != o.Val) return Val.CompareTo(o.Val);
            return Id.CompareTo(o.Id);
        }
    }
    
    SortedSet<Num> Large;
    SortedSet<Num> Small;
    
    public void AddNum(int num, int id) {
        if(Large.Count == 0) Large.Add(new Num(num, id));
        else if(num >= Large.Min.Val) Large.Add(new Num(num, id));
        else Small.Add(new Num(num, id));
        Balance();
    }
    
    public void RemoveNum(int num, int id){
        Num target = new Num(num, id);
        if(Large.Contains(target)) Large.Remove(target);
        else Small.Remove(target);
        Balance();
    }
    
    public void Balance(){
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
        return ((double)Large.Min.Val + (double)Small.Max.Val)/2.0;
    }
}
