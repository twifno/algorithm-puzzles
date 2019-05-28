//https://leetcode.com/problems/quad-tree-intersection/

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
    public Node Intersect(Node quadTree1, Node quadTree2) {
        if(quadTree1.isLeaf) {
            if(quadTree1.val) return quadTree1;
            else return quadTree2;
        } else if(quadTree2.isLeaf) {
            if(quadTree2.val) return quadTree2;
            else return quadTree1;
        } else {
            Node tl = Intersect(quadTree1.topLeft, quadTree2.topLeft);
            Node tr = Intersect(quadTree1.topRight, quadTree2.topRight);
            Node bl = Intersect(quadTree1.bottomLeft, quadTree2.bottomLeft);
            Node br = Intersect(quadTree1.bottomRight, quadTree2.bottomRight);
            if(tl.isLeaf && tr.isLeaf && br.isLeaf && bl.isLeaf
              && tl.val == tr.val && tl.val == bl.val && tl.val == br.val) return new Node(tl.val, true, null, null, null, null);
            else return new Node(false, false, tl, tr, bl, br);
        }
    }
}
