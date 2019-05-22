//https://leetcode.com/problems/binary-tree-postorder-traversal/

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
    public IList<int> PostorderTraversal(TreeNode root) {
        List<int> res = PreorderTraversal(root);
        res.Reverse();
        return res;
    }
    
    public List<int> PreorderTraversal(TreeNode root) {
        List<int> res = new List<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        if(root == null) return res;
        st.Push(root);
        while(st.Count > 0){
            TreeNode node = st.Pop();
            res.Add(node.val);
            if(node.left != null) st.Push(node.left);
            if(node.right != null) st.Push(node.right);
        }
        return res;
    }
}
