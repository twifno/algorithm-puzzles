//https://leetcode.com/problems/check-completeness-of-a-binary-tree/

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
    public bool IsCompleteTree(TreeNode root) {
        int depth;
        bool perfect;
        return IsCompleteTree(root, out depth, out perfect);
    }
    
    public bool IsCompleteTree(TreeNode root, out int depth, out bool isPerfect){
        if(root == null) {
            depth = -1;
            isPerfect = true;
            return true;
        }
        int lDepth;
        bool lPerfect;
        bool left = IsCompleteTree(root.left, out lDepth, out lPerfect);
        int rDepth;
        bool rPerfect;
        bool right = IsCompleteTree(root.right, out rDepth, out rPerfect);
        depth = Math.Max(lDepth, rDepth) + 1;
        isPerfect = lDepth == rDepth && lPerfect && rPerfect;
        if(!left || !right) return false;
        if(lDepth > rDepth+1 || lDepth < rDepth) return false;
        if(lDepth == rDepth && !lPerfect) return false;
        if(lDepth == rDepth+1 && !rPerfect) return false;
        return true;
    }   
}
