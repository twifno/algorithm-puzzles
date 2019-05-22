//https://leetcode.com/problems/unique-binary-search-trees-ii/

//Recursion - 

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
    public IList<TreeNode> GenerateTrees(int n) {
        if(n == 0) return new List<TreeNode>();
        return Gen(1, n);
    }
    
    public IList<TreeNode> Gen(int left, int right){
        List<TreeNode> res = new List<TreeNode>();
        if(left > right) {
            res.Add(null);
            return res;
        } else if(left == right){
            res.Add(new TreeNode(left));
            return res;
        } else {
            for(int i = left; i <= right; i++){
                IList<TreeNode> lefts = Gen(left, i-1);
                IList<TreeNode> rights = Gen(i+1, right);
                foreach(TreeNode ln in lefts){
                    foreach(TreeNode rn in rights){
                        TreeNode node = new TreeNode(i);
                        node.left = ln;
                        node.right = rn;
                        res.Add(node);
                    }
                }
            }
        }
        return res;
    }
}
