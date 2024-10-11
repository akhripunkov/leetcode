// See https://aka.ms/new-console-template for more information

TreeNode root = new TreeNode(1);
root.left = new TreeNode(2);
root.right = new TreeNode(3);
root.left.left = new TreeNode(7);
root.left.right = new TreeNode(5);
root.right.left = new TreeNode(8);
root.right.right = new TreeNode(4);
// root.left.left.left = new TreeNode(13);
// root.left.right.left = new TreeNode(6);
// root.left.right.right = new TreeNode(10);
// root.left.left.left.left = new TreeNode(14);
// root.left.right.left.left = new TreeNode(12);
// root.left.left.left.left.left = new TreeNode(15); 

Solution solution = new Solution();
IList<int> rightView = solution.RightSideView(root);

Console.WriteLine(string.Join(", ", rightView)); // Вывод: 1, 3, 4

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int value = 0, TreeNode leftNode = null, TreeNode rightNode = null)
    {
        val = value;
        left = leftNode;
        right = rightNode;
    }
}

public class Solution
{
    public IList<int> RightSideView(TreeNode root)
    {
        var result = new List<int>();
        if (root == null) return result;

        var queue = new Queue<TreeNode>();
        queue.Enqueue(root);

        while (queue.Count > 0)
        {
            int levelSize = queue.Count;

            for (int i = 0; i < levelSize; i++)
            {
                var currentNode = queue.Dequeue();

                if (i == levelSize - 1) // Последний элемент на уровне
                {
                    result.Add(currentNode.val);
                }

                if (currentNode.left != null)
                {
                    queue.Enqueue(currentNode.left);
                }

                if (currentNode.right != null)
                {
                    queue.Enqueue(currentNode.right);
                }
            }
        }

        return result;
    }
}

