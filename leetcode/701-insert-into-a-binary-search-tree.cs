//https://leetcode.com/problems/insert-into-a-binary-search-tree/

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
    public TreeNode InsertIntoBST(TreeNode root, int val) {
        TreeNode node = new TreeNode(val);
        if(root == null) return node;
        TreeNode cur = root;
        while(true) {
            if(cur.val > val){
                if(cur.left == null) {
                    cur.left = node;
                    break;
                } else cur = cur.left;
            } else {
                if(cur.right == null) {
                    cur.right = node;
                    break;
                } else cur = cur.right;
            }
        }
        return root;
    }
}
