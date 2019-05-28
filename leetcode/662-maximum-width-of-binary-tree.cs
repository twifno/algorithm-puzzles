//https://leetcode.com/problems/maximum-width-of-binary-tree/

//Not very efficient;

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
    class NullTreeNode: TreeNode {
        public NullTreeNode(): base(0) {}
    }
    
    public int WidthOfBinaryTree(TreeNode root) {
        int start = -1;
        int count = 0;
        int end = 0;
        int max = 0;
        if(root == null) return 0;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(new NullTreeNode());
        while(q.Count>0){
            TreeNode node = q.Dequeue();
            if(node is NullTreeNode){
                if(start != -1) max = Math.Max(max, end-start+1);
                start = -1;
                if(q.Count > 0) q.Enqueue(node);
                count = 0;
            } else if(node != null) {
                count += 1;
                if(start == -1) start = count;
                end = count;
                q.Enqueue(node.left);
                q.Enqueue(node.right);
            } else {
                count += 1;
                if(start != -1) {
                    q.Enqueue(null);
                    q.Enqueue(null);
                }
            }
        }
        return max;
    }
}
