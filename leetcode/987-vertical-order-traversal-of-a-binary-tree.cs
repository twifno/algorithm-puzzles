//https://leetcode.com/problems/vertical-order-traversal-of-a-binary-tree/

//Data structures and sorts

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
    class Cell {
        public int Depth;
        public int Val;
        public Cell(int d, int v){
            Depth = d;
            Val = v;
        }
    }
    
    public IList<IList<int>> VerticalTraversal(TreeNode root) {
        Dictionary<int, List<Cell>> map = new Dictionary<int, List<Cell>>();
        Build(root, 0, 0, map);
        List<int> poses = new List<int>(map.Keys);
        poses.Sort();
        List<IList<int>> res = new List<IList<int>>();
        foreach(int pos in poses){
            List<Cell> cells = map[pos];
            cells.Sort((x, y) => (x.Depth==y.Depth)?x.Val.CompareTo(y.Val):x.Depth.CompareTo(y.Depth));
            List<int> report = new List<int>();
            foreach(Cell c in cells) report.Add(c.Val);
            res.Add(report);
        }
        return res;
    }
    
    private void Build(TreeNode root, int depth, int pos, Dictionary<int, List<Cell>> map){
        if(root == null) return;
        Cell c = new Cell(depth, root.val);
        if(!map.ContainsKey(pos)) map[pos] = new List<Cell>();
        map[pos].Add(c);
        Build(root.left, depth+1, pos-1, map);
        Build(root.right, depth+1, pos+1, map);
    }
}
