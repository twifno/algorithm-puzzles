//https://leetcode.com/problems/subtree-of-another-tree/

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
    public bool IsSubtree(TreeNode s, TreeNode t) {
        if(s == null || t == null) return false;
        Stack<TreeNode> st = new Stack<TreeNode>();
        st.Push(s);
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(node.val == t.val && IsSameTree(node, t)) return true;
            if(node.left != null) st.Push(node.left);
            if(node.right != null) st.Push(node.right);
        }
        return false;
    }
    
    public bool IsSameTree(TreeNode s, TreeNode t) {
        if(s == null && t == null) return true;
        if(s == null || t == null) return false;
        if(s.val != t.val) return false;
        return IsSameTree(s.left, t.left) && IsSameTree(s.right, t.right);
    }
}
