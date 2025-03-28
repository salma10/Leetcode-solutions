/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    List<int> l1 = new(), l2 = new();
    public bool LeafSimilar(TreeNode root1, TreeNode root2) {
        DFS(root1, l1);
        DFS(root2, l2);
        return Enumerable.SequenceEqual(l1, l2);
    }
    
    private void DFS(TreeNode root, List<int> list)
    {
        if(root == null)
            return ;
        if(root.left == null && root.right == null)
            list.Add(root.val);
        DFS(root.left, list);
        DFS(root.right, list);
    }
}