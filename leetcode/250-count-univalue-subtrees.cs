//https://leetcode.com/problems/count-univalue-subtrees/

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
    public int CountUnivalSubtrees(TreeNode root) {
        bool isUni;
        return CountUnivalSubtrees(root, out isUni); 
    }
    
    private int CountUnivalSubtrees(TreeNode root, out bool isUni) {
        if(root == null){
            isUni = true;
            return 0;
        }
        bool uniLeft;
        bool uniRight;
        int cl = CountUnivalSubtrees(root.left, out uniLeft);
        int cr = CountUnivalSubtrees(root.right, out uniRight);
        if(uniLeft && uniRight){
            isUni = true;
            if(root.left != null && root.left.val != root.val) isUni = false;
            else if(root.right != null && root.right.val != root.val) isUni = false;
        } else {
            isUni = false;
        }
        if(isUni) return cl+cr+1;
        else return cl+cr;
    }
}
