//https://leetcode.com/problems/binary-tree-inorder-traversal/

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
    public IList<int> InorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Traversal(root, res);
        return res;
    }
    
    private void Traversal(TreeNode node, IList<int> res){
        if(node == null) return;
        Traversal(node.left, res);
        res.Add(node.val);
        Traversal(node.right, res);
    }
}
