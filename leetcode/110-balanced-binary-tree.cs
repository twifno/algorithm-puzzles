//https://leetcode.com/problems/balanced-binary-tree/

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
    public bool IsBalanced(TreeNode root) {
        int depth;
        return IsBalanced(root, out depth);
    }
    private bool IsBalanced(TreeNode root, out int depth){
        depth = 0;
        if(root == null) {
            return true;
        }
        int left, right;
        if(!IsBalanced(root.left, out left)) return false;
        if(!IsBalanced(root.right, out right)) return false;
        if(left > right+1 || left < right-1) return false;
        depth = Math.Max(left, right) + 1;
        return true;
    }
}
