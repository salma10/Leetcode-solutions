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
    
    int maxSum = int.MinValue;
    
    public int MaxPathSum(TreeNode root) {
        if(root == null)
            return 0;
        calculateMaxPath(root);
        return maxSum;
    }
    
    public int calculateMaxPath(TreeNode root)
    {
        if(root == null)
            return 0;
        
        int leftmax = Math.Max(calculateMaxPath(root.left), 0);
        int rightmax = Math.Max(calculateMaxPath(root.right), 0);
        
        int newPathSum = root.val + leftmax + rightmax;
        
        maxSum = Math.Max(newPathSum, maxSum);
        
        return root.val + Math.Max(leftmax, rightmax);
        
    }
    
}