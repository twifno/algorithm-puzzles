//https://leetcode.com/problems/longest-univalue-path/

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
    
    int Max;
    
    public int LongestUnivaluePath(TreeNode root) {
        Max = 0; 
        PathToChildren(root);
        return Max;
    }
    
    public int PathToChildren(TreeNode root) {
        if(root == null) return 0;
        int left = PathToChildren(root.left) + 1;
        if(root.left == null || root.left.val != root.val){
            left = 0;
        }
        int right = PathToChildren(root.right) + 1;
        if(root.right == null || root.right.val != root.val){
            right = 0;
        }
        Max = Math.Max(Max, left+right);
        return Math.Max(left, right);
    }
}
