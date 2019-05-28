//https://leetcode.com/problems/find-largest-value-in-each-tree-row/

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
    public IList<int> LargestValues(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        List<int> res = new List<int>();
        if(root == null) return res;
        int max = Int32.MinValue;
        q.Enqueue(root);
        q.Enqueue(null);
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            if(node == null){
                res.Add(max);
                max = Int32.MinValue;
                if(q.Count > 0) q.Enqueue(null);
            } else {
                max = Math.Max(max, node.val);
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
        }
        return res;
    }
}
