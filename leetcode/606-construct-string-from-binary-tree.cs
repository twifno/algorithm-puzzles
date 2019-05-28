//https://leetcode.com/problems/construct-string-from-binary-tree/

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
    public string Tree2str(TreeNode t) {
        if(t == null) return "";
        if(t.left == null && t.right == null) return t.val.ToString();
        if(t.right == null) return string.Format("{0}({1})", t.val, Tree2str(t.left));
        return string.Format("{0}({1})({2})", t.val, Tree2str(t.left), Tree2str(t.right));
    }
}
