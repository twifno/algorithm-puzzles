//https://leetcode.com/problems/minimum-distance-between-bst-nodes/

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
    public int MinDiffInBST(TreeNode root) {
        TreeNode pre = null;
        int min = Int32.MaxValue;
        Stack<TreeNode> st = new Stack<TreeNode>();
        while(root != null) { 
            st.Push(root);
            root = root.left;
        }
        while(st.Count > 0) {
            TreeNode n = st.Pop();
            if(pre != null) min = Math.Min(n.val - pre.val, min);
            pre = n;
            n = n.right;
            while(n != null) {
                st.Push(n);
                n = n.left;
            }
        }
        return min;
    }
}
