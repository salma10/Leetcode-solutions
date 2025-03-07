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
    public int MaxLevelSum(TreeNode root) {
        Queue<TreeNode> levelOrder = new Queue<TreeNode>();
        levelOrder.Enqueue(root);
        int resultLevel = 1;
        int maxSum = -100000;
        int currentLevel = 0;

        while(levelOrder.Count > 0)
        {
            int count = levelOrder.Count;
            int currentSum = 0;

            while(count > 0)
            {
                TreeNode current = levelOrder.Dequeue();
                if(current.left != null)
                   levelOrder.Enqueue(current.left); 
                if(current.right != null)
                   levelOrder.Enqueue(current.right); 
                count--;
                currentSum += current.val;
            }
            currentLevel++;
            if(maxSum < currentSum)   
            {
                maxSum = currentSum;
                resultLevel = currentLevel;
            }       
        }
        
        return resultLevel;
    }
}