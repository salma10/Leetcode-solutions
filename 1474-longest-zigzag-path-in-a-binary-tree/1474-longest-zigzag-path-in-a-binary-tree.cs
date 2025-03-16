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
    public int LongestZigZag(TreeNode root) {
        return Math.Max(MaxZigZag(root.left, "left", 1), MaxZigZag(root.right, "right", 1)) - 1;
    }

    private int MaxZigZag(TreeNode root, string direction, int value)
    {
        if(root == null)
            return value;
        int left,right;

        if(direction == "left")
        {
            right = MaxZigZag(root.right, "right", value + 1);
            left = MaxZigZag(root.left, "left", 1);
        }          
        else
        {
            left = MaxZigZag(root.left, "left", value + 1);
            right = MaxZigZag(root.right, "right", 1);
        }
        return Math.Max(right,left);
    }
}