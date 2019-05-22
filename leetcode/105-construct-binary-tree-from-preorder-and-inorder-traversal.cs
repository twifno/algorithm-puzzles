//https://leetcode.com/problems/construct-binary-tree-from-preorder-and-inorder-traversal/

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
    public TreeNode BuildTree(int[] preorder, int[] inorder) {
        return Build(preorder, inorder, 0, preorder.Length, 0, inorder.Length);
    }
    
    private TreeNode Build(int[] preorder, int[] inorder, int l1, int r1, int l2, int r2){
        if(l1 >= r1) return null;
        int val = preorder[l1];
        for(int i = l2; i < r2; i++) {
            if(inorder[i] == val){
                TreeNode node = new TreeNode(val);
                node.left = Build(preorder, inorder, l1+1, l1+1+i-l2, l2, i);
                node.right = Build(preorder, inorder, l1+1+i-l2, r1, i+1, r2);
                return node;
            }
        }
        return null;
    }
}
