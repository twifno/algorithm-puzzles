//https://leetcode.com/problems/sum-of-left-leaves/

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
    public int SumOfLeftLeaves(TreeNode root) {
        return SumOfLeftLeaves(root, false);
    }
    
    private int SumOfLeftLeaves(TreeNode root, bool isLeft){
        if(root == null) return 0;
        if(isLeft && root.left == null && root.right == null) return root.val;
        int sum = 0;
        sum += SumOfLeftLeaves(root.left, true);
        sum += SumOfLeftLeaves(root.right, false);
        return sum;
    }
}
