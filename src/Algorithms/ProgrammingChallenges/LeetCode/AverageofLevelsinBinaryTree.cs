namespace ProgrammingChallenges.LeetCode;

public static class AverageofLevelsinBinaryTree
{
    /*
    Given the root of a binary tree, return the average value of the 
    nodes on each level in the form of an array. Answers within 10-5 of the actual answer will be accepted. 
     */
    public static IList<double> AverageOfLevels(TreeNode root)
    {
        if (root == null)
            return [];

        IList<double> average = [];
        Queue<TreeNode> queue = [];
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            var levelSize = queue.Count;
            double levelSum = 0;

            for (var i = 0; i < levelSize; i++)
            {
                var node = queue.Dequeue();
                levelSum += node.val;

                if (node.left != null)
                    queue.Enqueue(node.left);
                if (node.right != null)
                    queue.Enqueue(node.right);
            }

            average.Add(levelSum / levelSize);
        }

        return average;
    }
}
