namespace ProgrammingChallenges.LeetCode;

public static class InvertBinaryTree
{
    /*
    Given the root of a binary tree, invert the tree, and return its root. 
     */
    public static TreeNode InvertTree(TreeNode root)
    {
        if (root == null)
            return root;

        (root.right, root.left) = (root.left, root.right);

        InvertTree(root.left);
        InvertTree(root.right);

        return root;
    }
}
