namespace ProgrammingChallenges.LeetCode;

public static class SameTree
{
    /*
    Given the roots of two binary trees p and q, write a function to check if they are the same or not.

    Two binary trees are considered the same if they are structurally identical, and the nodes have the same value. 
     */
    public static bool IsSameTree(TreeNode firstRoot, TreeNode secondRoot)
    {
        if (firstRoot == null && secondRoot == null)
            return true;
        else if (firstRoot == null || secondRoot == null || firstRoot.val != secondRoot.val)
            return false;

        return IsSameTree(firstRoot.left, secondRoot.left) && IsSameTree(firstRoot.right, secondRoot.right);
    }
}