//https://leetcode.com/problems/binary-tree-vertical-order-traversal/

//Have to be BFS to maintain the order

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
    
    class OrderTreeNode: TreeNode {
        public int order;
        public OrderTreeNode(TreeNode node, int order): base(node.val) {
            left = node.left;
            right = node.right;
            this.order = order;
        }
    }
    
    public IList<IList<int>> VerticalOrder(TreeNode root) {
        Dictionary<int, List<int>> dict = new Dictionary<int, List<int>>();
        Queue<OrderTreeNode> q = new Queue<OrderTreeNode>();
        if(root != null) q.Enqueue(new OrderTreeNode(root, 0));
        while(q.Count > 0){
            OrderTreeNode node = q.Dequeue();
            int order = node.order;
            if(!dict.ContainsKey(order)) dict[order] = new List<int>();
            dict[order].Add(node.val);
            if(node.left != null) q.Enqueue(new OrderTreeNode(node.left, order-1));
            if(node.right != null) q.Enqueue(new OrderTreeNode(node.right, order+1));
        }
        
        List<int> orders = new List<int>(dict.Keys);
        orders.Sort();
        List<IList<int>> res = new List<IList<int>>();
        foreach(int o in orders){
            res.Add(dict[o]);
        }
        return res;
    }
}
