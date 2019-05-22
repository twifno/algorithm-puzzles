//https://leetcode.com/problems/recover-binary-search-tree/

//In order traversal, only work with no duplication…
//Identify the first and second node.

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
    public void RecoverTree(TreeNode root) {
        TreeNode first = null;
        TreeNode second = null;
        TreeNode prev = null;
        if(root == null) return;
        Stack<TreeNode> st = new Stack<TreeNode>();
        TreeNode node = root;
        while(node != null) {
            st.Push(node);
            node = node.left;
        }
        while(st.Count > 0){
            node = st.Pop();
            if(prev == null) prev = node;
            else {
                if(prev.val > node.val) {
                    if(first == null){
                        first = prev;
                        second = node;
                    } else {
                        second = node;
                        break;
                    }
                }
                prev = node;
            }
            node = node.right;
            while(node != null){
                st.Push(node);
                node = node.left;
            }
        }
        int tmp = first.val;
        first.val = second.val;
        second.val = tmp;
    }
}

//This problem can be solved by Morris Traversal as well.
