//https://leetcode.com/problems/closest-binary-search-tree-value/

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
    public int ClosestValue(TreeNode root, double target) {
        int closest = root.val;
        TreeNode node = root;
        while(node != null){
            if(Math.Abs(closest - target) > Math.Abs(node.val - target)) closest = node.val;
            if(target == node.val) return closest;
            else if(target < node.val) node = node.left;
            else node = node.right;
        }
        return closest;
    }
}
