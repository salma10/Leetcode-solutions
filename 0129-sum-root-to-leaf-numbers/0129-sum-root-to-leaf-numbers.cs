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
    int sumRoottoLeaf;
    public int SumNumbers(TreeNode root) {
        sumRoottoLeaf = 0;
        generateRoute(root, 0);
        return sumRoottoLeaf;
    }
    
    public void generateRoute(TreeNode root, int currNumber) 
    {
        if (root == null)
            return;

          currNumber = currNumber * 10 + root.val;
            
          if (root.left == null && root.right == null) 
            sumRoottoLeaf += currNumber;
            
          generateRoute(root.left, currNumber);
          generateRoute(root.right, currNumber) ;
    }
}