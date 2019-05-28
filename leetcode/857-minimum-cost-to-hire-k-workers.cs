//https://leetcode.com/problems/minimum-cost-to-hire-k-workers/

public class Solution {
    class Worker {
        public int Q;
        public int W;
        public double R;
        public Worker(int q, int w) {
            Q = q;
            W = w;
            R = w*1.0/q;
        }
    }
    
    class WorkerComparer:IComparer<Worker> {
        public int Compare(Worker w1, Worker w2) {
            if(w2.Q == w1.Q) return w1.GetHashCode().CompareTo(w2.GetHashCode());
            return w2.Q.CompareTo(w1.Q);
        }    
    }
    
    public double MincostToHireWorkers(int[] quality, int[] wage, int K) {
        int len = quality.Length;
        Worker[] ws = new Worker[len];
        for(int i = 0; i < len; i++){
            ws[i] = new Worker(quality[i], wage[i]);
        }
        Array.Sort(ws, (x, y) => x.R.CompareTo(y.R));
        SortedSet<Worker> g = new SortedSet<Worker>(new WorkerComparer());
        int total = 0;
        double rate = 0;
        for(int i = 0; i < K; i++){
            total += ws[i].Q;
            rate = ws[i].R;
            g.Add(ws[i]);
        }
        double min = total * rate;
        for(int i = K; i < len; i++){
            total -= g.First().Q;
            g.Remove(g.First());
            total += ws[i].Q;
            rate = ws[i].R;
            g.Add(ws[i]);
            min = Math.Min(total*rate, min);
        }
        return min;
    }
}
