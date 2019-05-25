//https://leetcode.com/problems/count-complete-tree-nodes/

//Key concept - for a complete tree
//	- Left subtree and right subtree are also complete
//	- The height of the tree is the height of left child + 1

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
    public int CountNodes(TreeNode root) {
        if(root == null) return 0;
        int h1 = Height(root.left);
        int h2 = Height(root.right);
        if(h1 == h2){
            return (1 << h1) + CountNodes(root.right);
        } else {
            return (1 << h2) + CountNodes(root.left);
        }
    }
    
    private int Height(TreeNode root){
        int count = 0;
        while(root != null){
            count += 1;
            root = root.left;
        }
        return count;
    }
}
