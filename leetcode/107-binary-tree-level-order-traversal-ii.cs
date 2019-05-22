//https://leetcode.com/problems/binary-tree-level-order-traversal-ii/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class Solution {
    public IList<IList<int>> LevelOrderBottom(TreeNode root) {
        List<IList<int>> res = new List<IList<int>>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root == null) return res;
        List<int> cur = new List<int>();
        q.Enqueue(root);
        q.Enqueue(null);
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            if(node == null) {
                res.Add(cur);
                cur = new List<int>();
                if(q.Count > 0) q.Enqueue(null);
            } else {
                cur.Add(node.val);
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            } 
        }
        res.Reverse();
        return res;
    }
}
