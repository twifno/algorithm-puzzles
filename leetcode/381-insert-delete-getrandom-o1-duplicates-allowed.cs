//https://leetcode.com/problems/insert-delete-getrandom-o1-duplicates-allowed/

//GetEnumerator

public class RandomizedCollection {
    Dictionary<int, HashSet<int>> Dict;
    List<int> Indexes;
    Random Rand;

    /** Initialize your data structure here. */
    public RandomizedCollection() {
        Dict = new Dictionary<int, HashSet<int>>();
        Indexes = new List<int>();
        Rand = new Random();
    }
    
    /** Inserts a value to the collection. Returns true if the collection did not already contain the specified element. */
    public bool Insert(int val) {
        if(!Dict.ContainsKey(val)) Dict[val] = new HashSet<int>();
        Dict[val].Add(Indexes.Count);
        Indexes.Add(val);
        return Dict[val].Count == 1;
    }
    
    /** Removes a value from the collection. Returns true if the collection contained the specified element. */
    public bool Remove(int val) {
        if(!Dict.ContainsKey(val) || Dict[val].Count == 0) return false;
        HashSet<int>.Enumerator e = Dict[val].GetEnumerator();
        e.MoveNext();
        int index = e.Current;
        if(index == Indexes.Count - 1 || Indexes[Indexes.Count - 1] == val) {
            Dict[val].Remove(Indexes.Count-1);
            Indexes.RemoveAt(Indexes.Count-1);
        } else {
            Indexes[index] = Indexes[Indexes.Count-1];
            Dict[val].Remove(index);
            Dict[Indexes[index]].Remove(Indexes.Count-1);
            Dict[Indexes[index]].Add(index);
            Indexes.RemoveAt(Indexes.Count-1);
        }
        
        return true;
    }
    
    /** Get a random element from the collection. */
    public int GetRandom() {
        return Indexes[Rand.Next(Indexes.Count)];
    }
}

/**
 * Your RandomizedCollection object will be instantiated and called as such:
 * RandomizedCollection obj = new RandomizedCollection();
 * bool param_1 = obj.Insert(val);
 * bool param_2 = obj.Remove(val);
 * int param_3 = obj.GetRandom();
 */
