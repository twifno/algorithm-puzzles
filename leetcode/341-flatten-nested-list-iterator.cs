//https://leetcode.com/problems/flatten-nested-list-iterator/

/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class NestedIterator {

    IList<NestedInteger> NestedList;
    int cur;
    NestedIterator Iterator;
    
    public NestedIterator(IList<NestedInteger> nestedList) {
        NestedList = nestedList;
        cur = 0;
        Move();
    }

    public bool HasNext() {
        if(cur == NestedList.Count) return false;
        return true;
    }

    public int Next() {
        if(NestedList[cur].IsInteger()) {
            int val = NestedList[cur].GetInteger();
            cur += 1;
            Move();
            return val;
        } else {
            int val = Iterator.Next();
            if(!Iterator.HasNext()) {
                cur += 1;
                Move();
            }
            return val;
        }
    }
    
    private void Move() {
        while(cur < NestedList.Count){
            if(NestedList[cur].IsInteger()) break;
            Iterator = new NestedIterator(NestedList[cur].GetList());
            if(Iterator.HasNext()) break;
            cur += 1;
        }
    }
}

/**
 * Your NestedIterator will be called like this:
 * NestedIterator i = new NestedIterator(nestedList);
 * while (i.HasNext()) v[f()] = i.Next();
 */
