//https://leetcode.com/problems/insert-delete-getrandom-o1/

//Dictionary and Array
//Rand.Next

public class RandomizedSet {
    List<int> Indexes;
    Dictionary<int, int> Dict;
    Random Rand;
    
    /** Initialize your data structure here. */
    public RandomizedSet() {
        Indexes = new List<int>();
        Dict = new Dictionary<int, int>();
        Rand = new Random();
    }
    
    /** Inserts a value to the set. Returns true if the set did not already contain the specified element. */
    public bool Insert(int val) {
        if(Dict.ContainsKey(val)) return false;
        Dict[val] = Indexes.Count;
        Indexes.Add(val);
        return true;
    }
    
    /** Removes a value from the set. Returns true if the set contained the specified element. */
    public bool Remove(int val) {
        if(!Dict.ContainsKey(val)) return false;
        int index = Dict[val];
        Indexes[index] = Indexes[Indexes.Count-1];
        Dict[Indexes[index]] = index;
        Indexes.RemoveAt(Indexes.Count-1);
        Dict.Remove(val);
        return true;
    }
    
    /** Get a random element from the set. */
    public int GetRandom() {
        int next = Rand.Next(Indexes.Count);
        return Indexes[next];
    }
}

/**
 * Your RandomizedSet object will be instantiated and called as such:
 * RandomizedSet obj = new RandomizedSet();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
