//https://leetcode.com/problems/find-mode-in-binary-search-tree/

//Find the mode first then find all number that meet the mode.

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
    public int[] FindMode(TreeNode root) {
        if(root == null) return new int[0];
        int count = 0;
        int max = 0;
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode left = root;
        while(left != null){
            st.Push(left);
            left = left.left;
        }
        TreeNode pre = null;
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(pre == null) {
                pre = node;
                count = 1;
            } else if (pre.val != node.val) {
                pre = node;
                max = Math.Max(count, max);
                count = 1;
            } else {
                pre = node;
                count += 1;
            }
            node = node.right;
            while(node != null){
                st.Push(node);
                node = node.left;
            }
        }
        max = Math.Max(max, count);
        List<int> res = new List<int>();
        left = root;
        while(left != null){
            st.Push(left);
            left = left.left;
        }
        pre = null;
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(pre == null) {
                pre = node;
                count = 1;
            } else if (pre.val != node.val) {
                if(count == max) res.Add(pre.val);
                pre = node;
                count = 1;
            } else {
                pre = node;
                count += 1;
            }
            node = node.right;
            while(node != null){
                st.Push(node);
                node = node.left;
            }
        }
        if(count == max) res.Add(pre.val);
        return res.ToArray();
    }
}
