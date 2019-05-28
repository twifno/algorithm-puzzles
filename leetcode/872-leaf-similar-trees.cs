//https://leetcode.com/problems/leaf-similar-trees/

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
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        List<int> l1 = new List<int>();
        Leafs(root1, l1);
        List<int> l2 = new List<int>();
        Leafs(root2, l2);
        return Similar(l1, l2);
    }
    
    private void Leafs(TreeNode root, List<int> res){
        if(root == null) return;
        if(root.left == null && root.right == null) {
            res.Add(root.val);
            return;
        }
        Leafs(root.left, res);
        Leafs(root.right, res);
    }
    
    private bool Similar(List<int> l1, List<int> l2) {
        if(l1.Count != l2.Count) return false;
        for(int i = 0; i < l1.Count; i++) {
            if(l1[i] != l2[i]) return false;
        }
        return true;
    }
}
