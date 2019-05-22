//https://leetcode.com/problems/copy-list-with-random-pointer/

//Handle by recursion..

/**
 * Definition for singly-linked list with a random pointer.
 * public class RandomListNode {
 *     public int label;
 *     public RandomListNode next, random;
 *     public RandomListNode(int x) { this.label = x; }
 * };
 */
public class Solution {
    public RandomListNode CopyRandomList(RandomListNode head) {
        if(head == null) return null;
        Dictionary<int, RandomListNode> cache = new Dictionary<int, RandomListNode>();
        return Clone(head, cache);
    }
    
    public RandomListNode Clone(RandomListNode node, Dictionary<int, RandomListNode> cache){
        if(node == null) return null;
        if(cache.ContainsKey(node.label)) return cache[node.label];
        RandomListNode newNode = new RandomListNode(node.label);
        cache[node.label] = newNode;
        newNode.next = Clone(node.next, cache);
        newNode.random = Clone(node.random, cache);
        return newNode;
    } 
}

