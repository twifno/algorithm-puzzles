//https://leetcode.com/problems/equal-tree-partition/

//Be care of  0
//           / \
//          1   -1
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
    HashSet<int> Sums;
    public bool CheckEqualTree(TreeNode root) {
        Sums = new HashSet<int>();
        if(root == null) return false;
        int sum = root.val + Sum(root.left) + Sum(root.right);
        if(sum % 2 != 0) return false;
        if(Sums.Contains(sum/2)) return true;
        return false;
    }
    
    private int Sum(TreeNode root){
        if(root == null) return 0;
        int sum = root.val + Sum(root.left) + Sum(root.right);
        Sums.Add(sum);
        return sum;
    }
}
