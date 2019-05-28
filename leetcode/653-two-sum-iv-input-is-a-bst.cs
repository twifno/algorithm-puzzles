//https://leetcode.com/problems/two-sum-iv-input-is-a-bst/

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
    public bool FindTarget(TreeNode root, int k) {
        HashSet<int> hs = new HashSet<int>();
        Stack<TreeNode> st = new Stack<TreeNode>();
        if(root == null) return false;
        st.Push(root);
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(hs.Contains(k-node.val)) return true;
            hs.Add(node.val);
            if(node.left != null) st.Push(node.left);
            if(node.right != null) st.Push(node.right);
        }
        return false;
    }
}
