//https://leetcode.com/problems/kth-smallest-element-in-a-bst/

//In order traverse 

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
    public int KthSmallest(TreeNode root, int k) {
        int count = 1;
        Stack<TreeNode> st = new Stack<TreeNode>();
        while(root != null){
            st.Push(root);
            root = root.left;
        }
        while(st.Count > 0){
            TreeNode node = st.Pop();
            if(k == count) return node.val;
            count += 1;
            TreeNode right = node.right;
            while(right != null){
                st.Push(right);
                right = right.left;
            }
        }
        return 0;
    }
}
