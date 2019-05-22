//https://leetcode.com/problems/construct-binary-tree-from-inorder-and-postorder-traversal/

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
    public TreeNode BuildTree(int[] inorder, int[] postorder) {
         return Build(postorder, inorder, 0, postorder.Length, 0, inorder.Length);
    }
    
    private TreeNode Build(int[] postorder, int[] inorder, int l1, int r1, int l2, int r2){
        if(l1 >= r1) return null;
        int val = postorder[r1-1];
        for(int i = l2; i < r2; i++) {
            if(inorder[i] == val){
                TreeNode node = new TreeNode(val);
                node.left = Build(postorder, inorder, l1, l1+i-l2, l2, i);
                node.right = Build(postorder, inorder, l1+i-l2, r1-1, i+1, r2);
                return node;
            }
        }
        return null;
    }
}
