namespace ProgrammingChallenges.LeetCode;

public static class MinimumAbsoluteDifferenceinBST
{
    /*
    Given the root of a Binary Search Tree (BST), return the minimum absolute 
    difference between the values of any two different nodes in the tree. 
     */
    public static int GetMinimumDifference(TreeNode root)
    {
        TreeNode? previous = null;
        var result = float.MaxValue;

        GetMinimumDifference(root, ref previous, ref result);

        return (int)result;
    }

    private static void GetMinimumDifference(TreeNode node, ref TreeNode? previous, ref float result)
    {
        if (node == null)
            return;

        GetMinimumDifference(node.left, ref previous, ref result);

        if (previous != null)
            result = Math.Min(result, node.val - previous.val);

        previous = node;
        GetMinimumDifference(node.right, ref previous, ref result);
    }
}
