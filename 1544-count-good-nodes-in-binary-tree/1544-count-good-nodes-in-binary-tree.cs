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
    public int GoodNodes(TreeNode root) {
        return CountGoodNodes(root, root.val);
    }

    public int CountGoodNodes(TreeNode root, int max)
    {
        if(root == null)
            return 0;
        if(root.val >= max)
            return 1 + CountGoodNodes(root.left, root.val) + CountGoodNodes(root.right, root.val);
        else
            return CountGoodNodes(root.left, max) + CountGoodNodes(root.right, max);
    }
}