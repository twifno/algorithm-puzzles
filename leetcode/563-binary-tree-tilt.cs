//https://leetcode.com/problems/binary-tree-tilt/

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
    class SumAndTilt {
        public int Sum;
        public int Tilt;
        public int TiltSum;
        public SumAndTilt(int s, int t, int ts){
            Sum = s;
            Tilt = t;
            TiltSum = ts;
        }
    }
    
    public int FindTilt(TreeNode root) {
        return Find(root).TiltSum;
    }
    
    private SumAndTilt Find(TreeNode root) {
        if(root == null) return new SumAndTilt(0, 0, 0);
        SumAndTilt left = Find(root.left);
        SumAndTilt right = Find(root.right);
        int tilt = (int)Math.Abs(left.Sum-right.Sum);
        return new SumAndTilt(left.Sum + right.Sum + root.val, tilt, left.TiltSum + right.TiltSum + tilt);
    }
}
