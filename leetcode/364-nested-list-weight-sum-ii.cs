//https://leetcode.com/problems/nested-list-weight-sum-ii/

//Checking depth before calculating the sum, any better solution?

/**
 * // This is the interface that allows for creating nested lists.
 * // You should not implement it, or speculate about its implementation
 * interface NestedInteger {
 *
 *     // Constructor initializes an empty nested list.
 *     public NestedInteger();
 *
 *     // Constructor initializes a single integer.
 *     public NestedInteger(int value);
 *
 *     // @return true if this NestedInteger holds a single integer, rather than a nested list.
 *     bool IsInteger();
 *
 *     // @return the single integer that this NestedInteger holds, if it holds a single integer
 *     // Return null if this NestedInteger holds a nested list
 *     int GetInteger();
 *
 *     // Set this NestedInteger to hold a single integer.
 *     public void SetInteger(int value);
 *
 *     // Set this NestedInteger to hold a nested list and adds a nested integer to it.
 *     public void Add(NestedInteger ni);
 *
 *     // @return the nested list that this NestedInteger holds, if it holds a nested list
 *     // Return null if this NestedInteger holds a single integer
 *     IList<NestedInteger> GetList();
 * }
 */
public class Solution {
    public int DepthSumInverse(IList<NestedInteger> nestedList) {
        int depth = Depth(nestedList);
        return DepthSumInverse(nestedList, depth, 0);
    }
    
    private int Depth(IList<NestedInteger> nestedList){
        int depth = 1;
        foreach(NestedInteger ni in nestedList){
            if(!ni.IsInteger()){
                depth = Math.Max(depth, Depth(ni.GetList()) + 1);
            }
        }
        return depth;
    }
    
    private int DepthSumInverse(IList<NestedInteger> nestedList, int depth, int curDepth){
        int sum = 0;
        foreach(NestedInteger ni in nestedList){
            if(ni.IsInteger()) {
                sum += (depth-curDepth) * ni.GetInteger();
            } else {
                sum += DepthSumInverse(ni.GetList(), depth, curDepth + 1);
            }
        }
        return sum;
    }
}
