//https://leetcode.com/problems/minimum-absolute-difference-in-bst/

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
    public int GetMinimumDifference(TreeNode root) {
        TreeNode pre = null;
        Stack<TreeNode> st = new Stack<TreeNode>();
        int min = Int32.MaxValue;
        while(root != null){
            st.Push(root);
            root = root.left;
        }
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(pre != null){
                min = Math.Min(min, node.val - pre.val);
            }
            pre = node;
            node = node.right;
            while(node != null){
                st.Push(node);
                node = node.left;
            }
        }
        return min;
    }
}
