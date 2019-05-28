//https://leetcode.com/problems/smallest-subtree-with-all-the-deepest-nodes/

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
    public TreeNode SubtreeWithAllDeepest(TreeNode root) {
        Dictionary<TreeNode, int> depths = new Dictionary<TreeNode, int>();
        SetDepths(root, depths, 0);
        return SubtreeWithAllDeepest(root, depths);
    }
    
    private int SetDepths(TreeNode root, Dictionary<TreeNode, int> depths, int d){
        if(root == null) return d;
        int left = SetDepths(root.left, depths, d+1);
        int right = SetDepths(root.right, depths, d+1);
        depths[root] = Math.Max(left, right);
        return depths[root];
    }
    
    private TreeNode SubtreeWithAllDeepest(TreeNode root, Dictionary<TreeNode, int> depths) {
        while(root != null){
            if(root.left == null && root.right == null) return root;
            else if(root.left == null) root = root.right;
            else if(root.right == null) root = root.left;
            else if(depths[root.left] == depths[root.right]) return root;
            else if (depths[root.left] < depths[root.right]) root = root.right;
            else root = root.left;
        }
        return root;
    }
}
