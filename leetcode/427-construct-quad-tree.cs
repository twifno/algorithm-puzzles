//https://leetcode.com/problems/construct-quad-tree/

/*
// Definition for a QuadTree node.
public class Node {
    public bool val;
    public bool isLeaf;
    public Node topLeft;
    public Node topRight;
    public Node bottomLeft;
    public Node bottomRight;

    public Node(){}
    public Node(bool _val,bool _isLeaf,Node _topLeft,Node _topRight,Node _bottomLeft,Node _bottomRight) {
        val = _val;
        isLeaf = _isLeaf;
        topLeft = _topLeft;
        topRight = _topRight;
        bottomLeft = _bottomLeft;
        bottomRight = _bottomRight;
}
*/
public class Solution {
    public Node Construct(int[][] grid) {
        return Build(grid, 0, 0, grid.Length, grid.Length);
    }
    private Node Build(int[][] grid, int lx, int ly, int rx, int ry){
        Node n = new Node();
        n.isLeaf = true;
        int b = grid[lx][ly];
        for(int i = lx; i < rx; i++){
            for(int j = ly; j < ry; j++){
                if(grid[i][j] != b) {
                    n.isLeaf = false;
                    break;
                }
            }
        }
        if(n.isLeaf) {
            n.val = (b == 1);
            return n;
        }
        n.topLeft = Build(grid, lx, ly, (lx+rx)/2, (ly+ry)/2);
        n.topRight = Build(grid, lx, (ly+ry)/2, (lx+rx)/2, ry);
        n.bottomLeft = Build(grid, (lx+rx)/2, ly, rx, (ly+ry)/2);
        n.bottomRight = Build(grid, (lx+rx)/2, (ly+ry)/2, rx, ry);
        return n;
    }
}
