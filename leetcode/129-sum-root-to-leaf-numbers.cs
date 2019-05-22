//https://leetcode.com/problems/sum-root-to-leaf-numbers/

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
    public int SumNumbers(TreeNode root) {
        int sum = 0;
        Sum(root, 0, ref sum);
        return sum;
    }
    
    private void Sum(TreeNode root, int cur, ref int sum){
        if(root == null) return;
        cur = cur * 10 + root.val;
        if(root.left == null && root.right == null) {
            sum += cur;
            return;
        }
        Sum(root.left, cur, ref sum);
        Sum(root.right, cur, ref sum);
    }
}
