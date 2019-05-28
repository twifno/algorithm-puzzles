//https://leetcode.com/problems/find-bottom-left-tree-value/

//It would be easier to do RTL BFS

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
    public int FindBottomLeftValue(TreeNode root) {
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(null);
        q.Enqueue(root);
        int val = root.val;
        bool next = false;
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            if(node == null){
                next = true;
                if(q.Count > 0) q.Enqueue(null);
            } else {
                if(next) {
                    val = node.val;
                    next = false;
                }
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
        }
        return val;
    }
}
