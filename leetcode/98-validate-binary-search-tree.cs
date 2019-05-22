//https://leetcode.com/problems/validate-binary-search-tree/

//Doing an in order traversal.

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
    public bool IsValidBST(TreeNode root) {
        int? cur = null;
        return Check(root, ref cur);
    }
    
    public bool Check(TreeNode root, ref int? cur){
        if(root == null) return true;
        if(!Check(root.left, ref cur)) return false;
        if(cur != null && root.val <= cur) return false;
        cur = root.val;
        if(!Check(root.right, ref cur)) return false;
        return true;
    }
}
