namespace ProgrammingChallenges.LeetCode;

public static class SymmetricTree
{
    /*
    Given the root of a binary tree, check whether it is a mirror of itself (i.e., symmetric around its center). 
     */
    public static bool IsSymmetric(TreeNode root)
    {
        return IsSymmetric(root.left, root.right);
    }

    private static bool IsSymmetric(TreeNode left, TreeNode right)
    {
        if (left == null && right == null)
            return true;
        else if (left == null || right == null)
            return false;

        return left.val == right.val && IsSymmetric(left.left, right.right) && IsSymmetric(left.right, right.left);
    }
}
