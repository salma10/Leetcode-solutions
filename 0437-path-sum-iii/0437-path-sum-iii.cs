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

    public int PathSum(TreeNode root, int targetSum) {
        if(root == null)
            return 0;      
        return PathSumDFS(root, (long)targetSum, 0) + PathSum(root.left, targetSum) + PathSum(root.right, targetSum);
    }

    public int PathSumDFS(TreeNode root, long sum, long currentSum) {
        if(root == null)
            return 0;
        else
            return (currentSum + root.val == sum ? 1 : 0 ) + PathSumDFS(root.left, sum, currentSum + root.val) + PathSumDFS(root.right, sum, currentSum + root.val);
    }
}