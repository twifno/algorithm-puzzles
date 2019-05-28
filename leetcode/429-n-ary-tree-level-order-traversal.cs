//https://leetcode.com/problems/n-ary-tree-level-order-traversal/

//Level traversal in general.

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
    public IList<IList<int>> LevelOrder(Node root) {
        List<IList<int>> res = new List<IList<int>>();
        if(root == null) return res;
        Queue<Node> q = new Queue<Node>();
        q.Enqueue(null);
        q.Enqueue(root);
        while(q.Count > 0){
            Node n = q.Dequeue();
            if(n == null) {
                if(q.Count > 0) {
                    res.Add(new List<int>());
                    q.Enqueue(null);
                }
            } else {
                res[res.Count-1].Add(n.val);
                foreach(Node c in n.children){
                    if(c != null) q.Enqueue(c);
                }
            }
        }
        return res;
    }
}
