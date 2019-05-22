//https://leetcode.com/problems/path-sum-ii/

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
    public IList<IList<int>> PathSum(TreeNode root, int sum) {
        List<IList<int>> res = new List<IList<int>>();
        if(root == null) return res;
        List<int> cur = new List<int>();
        FindPath(root, sum, res, cur);
        return res;
    }
    
    private void FindPath(TreeNode root, int sum, List<IList<int>> res, List<int> cur){
        if(root.left == null && root.right == null){
            if(root.val == sum) {
                cur.Add(root.val);
                res.Add(new List<int>(cur));
                cur.RemoveAt(cur.Count-1);
                return;
            }
        }
        cur.Add(root.val);
        if(root.left != null){
            FindPath(root.left, sum - root.val, res, cur);
        }
        if(root.right != null){
            FindPath(root.right, sum - root.val, res, cur);
        }
        cur.RemoveAt(cur.Count-1);
    }
}
