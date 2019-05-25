//https://leetcode.com/problems/binary-tree-right-side-view/

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
    public IList<int> RightSideView(TreeNode root) {
        List<int> res = new List<int>();
        Queue<TreeNode> q = new Queue<TreeNode>();
        if(root == null) return res;
        q.Enqueue(root);
        q.Enqueue(null);
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            if(node == null) {
                if(q.Count > 0) q.Enqueue(null);
            } else {
                if(q.Peek() == null) res.Add(node.val);
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
        }
        return res;
    }
}
