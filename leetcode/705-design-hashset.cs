//https://leetcode.com/problems/design-hashset/

public class MyHashSet {

    bool[] Dict;
        
    /** Initialize your data structure here. */
    public MyHashSet() {
        Dict = new bool[1000001];
    }
    
    public void Add(int key) {
        Dict[key] = true;
    }
    
    public void Remove(int key) {
        Dict[key] = false;
    }
    
    /** Returns true if this set contains the specified element */
    public bool Contains(int key) {
        return Dict[key];
    }
}

/**
 * Your MyHashSet object will be instantiated and called as such:
 * MyHashSet obj = new MyHashSet();
 * obj.Add(key);
 * obj.Remove(key);
 * bool param_3 = obj.Contains(key);
 */
