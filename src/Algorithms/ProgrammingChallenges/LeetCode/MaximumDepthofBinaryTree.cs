namespace ProgrammingChallenges.LeetCode;

public static class MaximumDepthofBinaryTree
{
    /*
    Given the root of a binary tree, return its maximum depth.

    A binary tree's maximum depth is the number of nodes along the longest path from the root node down to the farthest leaf node. 
     */
    public static int MaxDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        return GetDepth(root);
    }

    private static int GetDepth(TreeNode root)
    {
        if (root == null)
            return 0;

        return Math.Max(GetDepth(root.left), GetDepth(root.right)) + 1;
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;

    public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
    {
        this.val = val;
        this.left = left;
        this.right = right;
    }
}
