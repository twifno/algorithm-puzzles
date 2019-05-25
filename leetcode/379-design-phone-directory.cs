//https://leetcode.com/problems/design-phone-directory/

public class PhoneDirectory {
    Queue<int> Available;
    HashSet<int> Used;

    /** Initialize your data structure here
        @param maxNumbers - The maximum numbers that can be stored in the phone directory. */
    public PhoneDirectory(int maxNumbers) {
        Available = new Queue<int>();
        Used = new HashSet<int>();
        for(int i = 0; i < maxNumbers; i++) Available.Enqueue(i);
    }
    
    /** Provide a number which is not assigned to anyone.
        @return - Return an available number. Return -1 if none is available. */
    public int Get() {
        if(Available.Count == 0) return -1;
        int next = Available.Dequeue();
        Used.Add(next);
        return next;
    }
    
    /** Check if a number is available or not. */
    public bool Check(int number) {
        return !Used.Contains(number);
    }
    
    /** Recycle or release a number. */
    public void Release(int number) {
        if(!Used.Contains(number)) return;
        Used.Remove(number);
        Available.Enqueue(number);
    }
}

/**
 * Your PhoneDirectory object will be instantiated and called as such:
 * PhoneDirectory obj = new PhoneDirectory(maxNumbers);
 * int param_1 = obj.Get();
 * bool param_2 = obj.Check(number);
 * obj.Release(number);
 */
