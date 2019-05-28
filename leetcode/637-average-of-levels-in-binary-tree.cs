//https://leetcode.com/problems/average-of-levels-in-binary-tree/

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
    public IList<double> AverageOfLevels(TreeNode root) {
        int count = 0;
        double sum = 0;
        List<double> res = new List<double>();
        if(root == null) return res;
        Queue<TreeNode> q = new Queue<TreeNode>();
        q.Enqueue(root);
        q.Enqueue(null);
        while(q.Count > 0){
            TreeNode node = q.Dequeue();
            if(node == null) {
                res.Add(sum/count);
                count = 0;
                sum = 0;
                if(q.Count > 0) q.Enqueue(null);
            } else {
                count += 1;
                sum += node.val;
                if(node.left != null) q.Enqueue(node.left);
                if(node.right != null) q.Enqueue(node.right);
            }
        }
        return res;
    }
}
