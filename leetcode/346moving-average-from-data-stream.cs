//https://leetcode.com/problems/moving-average-from-data-stream/

public class MovingAverage {

    int Size;
    Queue<int> Q;
    double Sum;
    
    /** Initialize your data structure here. */
    public MovingAverage(int size) {
        Size = size;
        Q = new Queue<int>();
    }
    
    public double Next(int val) {
        Sum += val;
        Q.Enqueue(val);
        if(Q.Count > Size) Sum -= Q.Dequeue();
        return Sum / Q.Count;
    }
}

/**
 * Your MovingAverage object will be instantiated and called as such:
 * MovingAverage obj = new MovingAverage(size);
 * double param_1 = obj.Next(val);
 */
