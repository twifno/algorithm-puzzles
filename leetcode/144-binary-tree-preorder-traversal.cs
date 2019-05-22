//https://leetcode.com/problems/binary-tree-preorder-traversal/

//Iterative solution using stack..

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
    public IList<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        if(root == null) return res;
        st.Push(root);
        while(st.Count > 0){
            TreeNode node = st.Pop();
            res.Add(node.val);
            if(node.right != null) st.Push(node.right);
            if(node.left != null) st.Push(node.left);
        }
        return res;
    }
}
