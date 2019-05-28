//https://leetcode.com/problems/maximum-depth-of-n-ary-tree/

/*
// Definition for a Node.
public class Node {
    public int val;
    public IList<Node> children;

    public Node(){}
    public Node(int _val,IList<Node> _children) {
        val = _val;
        children = _children;
}
*/
public class Solution {
    public int MaxDepth(Node root) {
        int max = 0;
        if(root == null) return 0;
        foreach(Node n in root.children){
            max = Math.Max(max, MaxDepth(n));
        }
        return max+1;
    }
}
