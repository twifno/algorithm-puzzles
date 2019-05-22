//https://leetcode.com/problems/binary-tree-maximum-path-sum/

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
    public int MaxPathSum(TreeNode root) {
        Max = Int32.MinValue;
        Find(root);
        return Max;
    }
    private int Find(TreeNode root){
        if(root == null) return 0;
        if(root.left == null && root.right == null) {
            Max = Math.Max(Max, root.val);
            return root.val;
        }
        int sum = root.val;
        int left = Find(root.left);
        int right = Find(root.right);
        sum = Math.Max(sum, root.val+left);
        sum = Math.Max(sum, root.val+right);
        Max = Math.Max(Max, root.val+(left>0?left:0)+(right>0?right:0));
        return sum;
    }
}
