//https://leetcode.com/problems/find-leaves-of-binary-tree/

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
    public IList<IList<int>> FindLeaves(TreeNode root) {
        List<IList<int>> res = new List<IList<int>>();
        int d;
        Find(root, res, out d);
        return res;
    }
    
    private void Find(TreeNode root, List<IList<int>> res, out int depth){
        depth = 0;
        if(root == null) return;
        int d1;
        Find(root.left, res, out d1);
        int d2;
        Find(root.right, res, out d2);
        int d = Math.Max(d1, d2);
        if(res.Count <= d){
            res.Add(new List<int>());
        }
        res[d].Add(root.val);
        depth = d + 1;
        return;
    }
}
