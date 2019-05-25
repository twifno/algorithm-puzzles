//https://leetcode.com/problems/house-robber-iii/

//Cache will be useful for performance.

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
    Dictionary<TreeNode, int> With = new Dictionary<TreeNode, int>();
    Dictionary<TreeNode, int> Without = new Dictionary<TreeNode, int>();
    
    public int Rob(TreeNode root) {
        if(root == null) return 0;
        if(With.ContainsKey(root)) return With[root];
        //rob with root
        int total1 = root.val + RobWithoutRoot(root.left) + RobWithoutRoot(root.right);
        int total2 = RobWithoutRoot(root);
        With[root] = Math.Max(total1, total2);
        return With[root];
    }
    
    public int RobWithoutRoot(TreeNode root){
        if(root == null) return 0;
        if(Without.ContainsKey(root)) return Without[root];
        Without[root] = Rob(root.left) + Rob(root.right);
        return Without[root];
    }
}
