//https://leetcode.com/problems/maximum-binary-tree/

//This can be O(n) by using stack in a more efficient way.

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
    public TreeNode ConstructMaximumBinaryTree(int[] nums) {
        return Construct(nums, 0, nums.Length-1);
    }
    
    public TreeNode Construct(int[] nums, int f, int t){
        Stack<int> st = new Stack<int>();
        for(int i = f; i <= t; i++){
            if(st.Count == 0) st.Push(i);
            else {
                if(nums[st.Peek()] < nums[i]) st.Push(i);
            }
        }
        TreeNode root = null;
        TreeNode last = null;
        int end = t;
        while(st.Count > 0){
            int pos = st.Pop();
            TreeNode node = new TreeNode(nums[pos]);
            if(root == null) {
                root = node;
                last = node;
            } else {
                last.left = node;
                last = node;
            }
            if(end > pos) {
                node.right = Construct(nums, pos+1, end);
            }
            end = pos-1;
        }
        return root;
    }
    
}
