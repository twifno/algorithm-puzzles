//https://leetcode.com/problems/largest-bst-subtree/

//Return can be wrapped to an object.

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
    int Max;
    
    public int LargestBSTSubtree(TreeNode root) {
        Max = 0;
        int n, l, s;
        IsBST(root, out n, out l, out s);
        return Max;
    }
    
    private bool IsBST(TreeNode root, out int num, out int largest, out int smallest){
        if(root == null){
            num = 0;
            largest = 0;
            smallest = 0;
            return true;
        }
        int ln, ll, ls;
        bool isLBST = IsBST(root.left, out ln, out ll, out ls);
        int rn, rl, rs;
        bool isRBST = IsBST(root.right, out rn, out rl, out rs);
        num = ln + rn + 1;
        largest = 0;
        smallest = 0;
        if(!isLBST || !isRBST) return false;
        if(ln > 0){
            smallest = ls;
            if(root.val <= ll) return false;
        } else {
            smallest = root.val;
        }
        if(rn > 0){
            largest = rl;
            if(root.val >= rs) return false;
        } else {
            largest = root.val;
        }
        Max = Math.Max(num, Max);
        return true;
    }
}
