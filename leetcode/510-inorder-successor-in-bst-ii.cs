//https://leetcode.com/problems/inorder-successor-in-bst-ii/

/*
// Definition for a Node.
public class Node {
    public int val;
    public Node left;
    public Node right;
    public Node parent;
}
*/
public class Solution {
    public Node InorderSuccessor(Node x) {
        if(x.right == null){
            while(x.parent != null && x.parent.val < x.val) x = x.parent;
            return x.parent;
        }
        x = x.right;
        while(x.left != null){ x = x.left; }
        return x;
    }
}
