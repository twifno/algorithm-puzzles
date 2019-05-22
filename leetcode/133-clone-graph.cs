//https://leetcode.com/problems/clone-graph/

/**
 * Definition for undirected graph.
 * public class UndirectedGraphNode {
 *     public int label;
 *     public IList<UndirectedGraphNode> neighbors;
 *     public UndirectedGraphNode(int x) { label = x; neighbors = new List<UndirectedGraphNode>(); }
 * };
 */
public class Solution {
    public UndirectedGraphNode CloneGraph(UndirectedGraphNode node) {
        if(node == null) return null;
        Dictionary<int, UndirectedGraphNode> cache = new Dictionary<int, UndirectedGraphNode>();
        return Clone(node, cache);
    }
    
    public UndirectedGraphNode Clone(UndirectedGraphNode node, Dictionary<int, UndirectedGraphNode> cache){
        if(cache.ContainsKey(node.label)) return cache[node.label];
        UndirectedGraphNode newNode = new UndirectedGraphNode(node.label);
        cache[node.label] = newNode;
        foreach(UndirectedGraphNode neig in node.neighbors){
            newNode.neighbors.Add(Clone(neig, cache));
        }
        return newNode;
    } 
}
