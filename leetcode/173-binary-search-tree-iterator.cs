//https://leetcode.com/problems/binary-search-tree-iterator/

/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int x) { val = x; }
 * }
 */
public class BSTIterator {
    
    Stack<TreeNode> st;
    
    public BSTIterator(TreeNode root) {
        st = new Stack<TreeNode>();
        TreeNode node = root;
        while(node != null){
            st.Push(node);
            node = node.left;
        }
    }
    
    /** @return the next smallest number */
    public int Next() {
        TreeNode node = st.Pop();
        int val = node.val;
        node = node.right;
        while(node != null){
            st.Push(node);
            node = node.left;
        }
        return val;
    }
    
    /** @return whether we have a next smallest number */
    public bool HasNext() {
        return st.Count > 0;
    }
}

/**
 * Your BSTIterator object will be instantiated and called as such:
 * BSTIterator obj = new BSTIterator(root);
 * int param_1 = obj.Next();
 * bool param_2 = obj.HasNext();
 */
