//https://leetcode.com/problems/design-hit-counter/

public class HitCounter {
    class Counter {
        public int ts;
        public int count;
        public Counter(int ts, int count){
            this.ts = ts;
            this.count = count;
        }
    }
    
    Queue<Counter> Q;
    Counter CurrentCounter;
    int Sum;
    
    /** Initialize your data structure here. */
    public HitCounter() {
        Q = new Queue<Counter>();
        Sum = 0;
    }
    
    /** Record a hit.
        @param timestamp - The current timestamp (in seconds granularity). */
    public void Hit(int timestamp) {
        if(CurrentCounter == null){
            CurrentCounter = new Counter(timestamp, 1);
            Sum += 1;
        } else if(CurrentCounter.ts == timestamp){
            CurrentCounter.count += 1;
            Sum += 1;
        } else {
            Q.Enqueue(CurrentCounter);
            CurrentCounter = new Counter(timestamp, 1);
            Sum += 1;
        }
    }
    
    /** Return the number of hits in the past 5 minutes.
        @param timestamp - The current timestamp (in seconds granularity). */
    public int GetHits(int timestamp) {
        while(Q.Count > 0 && Q.Peek().ts + 300 <= timestamp){
            Sum -= Q.Dequeue().count;
        }
        if(CurrentCounter != null && CurrentCounter.ts + 300 <= timestamp){
            Sum = 0;
            CurrentCounter = null;
        }
        return Sum;
    }
}

/**
 * Your HitCounter object will be instantiated and called as such:
 * HitCounter obj = new HitCounter();
 * obj.Hit(timestamp);
 * int param_2 = obj.GetHits(timestamp);
 */
