//https://leetcode.com/problems/binary-tree-longest-consecutive-sequence-ii/

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
    public int LongestConsecutive(TreeNode root) {
        int[] f = Find(root);
        return f[2];
    }
    
    private int[] Find(TreeNode root){
        if(root == null) return new int[3] {0, 0, 0};
        if(root.left == null && root.right == null) return new int[3] {0, 0, 1};
        int[] f1 = Find(root.left);
        int[] f2 = Find(root.right);
        if(root.left == null) {
            if(root.val == root.right.val+1){
                int inc = f2[0] + 1;
                int con = Math.Max(inc+1, f2[2]);
                return new int[3] {inc, 0, con};
            } else if(root.val == root.right.val-1){
                int dec = f2[1] + 1;
                int con = Math.Max(dec+1, f2[2]);
                return new int[3] {0, dec, con};
            } else {
                return new int[3] {0, 0, f2[2]};
            }
        } else if(root.right == null) {
            if(root.val == root.left.val+1){
                int inc = f1[0] + 1;
                int con = Math.Max(inc+1, f1[2]);
                return new int[3] {inc, 0, con};
            } else if(root.val == root.left.val-1){
                int dec = f1[1] + 1;
                int con = Math.Max(dec+1, f1[2]);
                return new int[3] {0, dec, con};
            } else {
                return new int[3] {0, 0, f1[2]};
            }
        } else {
            int inc1 = 0;
            if(root.val == root.left.val + 1) inc1 = f1[0] + 1;
            int inc2 = 0;
            if(root.val == root.right.val + 1) inc2 = f2[0] + 1;
            int inc = Math.Max(inc1, inc2);
            int dec1 = 0;
            if(root.val == root.left.val - 1) dec1 = f1[1] + 1;
            int dec2 = 0;
            if(root.val == root.right.val - 1) dec2 = f2[1] + 1;
            int dec = Math.Max(dec1, dec2);
            int con = Math.Max(inc1+dec2+1, inc2+dec1+1);
            con = Math.Max(con, f1[2]);
            con = Math.Max(con, f2[2]);
            return new int[3] {inc, dec, con};
        }
    }
}
