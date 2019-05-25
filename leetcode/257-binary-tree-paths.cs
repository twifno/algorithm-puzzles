//https://leetcode.com/problems/binary-tree-paths/

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
    public IList<string> BinaryTreePaths(TreeNode root) {
        List<string> res = new List<string>();
        List<int> cur = new List<int>();
        Find(root, res, cur);
        return res;
    }
    
    private void Find(TreeNode node, List<string> res, List<int> cur){
        if(node == null) return;
        if(node.left == null && node.right == null) {
            cur.Add(node.val);
            res.Add(string.Join("->", cur));
            cur.RemoveAt(cur.Count-1);
            return;
        }
        cur.Add(node.val);
        Find(node.left, res, cur);
        Find(node.right, res, cur);
        cur.RemoveAt(cur.Count-1);
    }
}
