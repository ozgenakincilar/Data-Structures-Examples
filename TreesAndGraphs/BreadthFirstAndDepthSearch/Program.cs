namespace BreadthFirstAndDepthSearch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = new TreeNode(1);
            root.left = new TreeNode(2);
            root.right = new TreeNode(3);
            root.left.left = new TreeNode(4);
            root.left.right = new TreeNode(5);
            root.right.left = new TreeNode(6);
            root.right.right = new TreeNode(7);

            Console.WriteLine("Breadth-First Search (BFS):");
            BreadthFirstSearch(root);
            Console.WriteLine();

            Console.WriteLine("\nDepth-First Search (DFS):");
            DepthFirstSearch(root);
            Console.WriteLine();
        }

        public static void DepthFirstSearch(TreeNode root)
        {
            if (root == null)
                return;

            Stack<TreeNode> stack = new Stack<TreeNode>();
            stack.Push(root);

            while (stack.Count > 0)
            {
                TreeNode node = stack.Pop();
                Console.Write(node.val + " ");

                if (node.right != null)
                    stack.Push(node.right);

                if (node.left != null)
                    stack.Push(node.left);
            }
        }

        public static void BreadthFirstSearch(TreeNode root)
        {
            if (root == null)
                return;

            Queue<TreeNode> queue = new Queue<TreeNode>();
            queue.Enqueue(root);

            while (queue.Count > 0)
            {
                TreeNode node = queue.Dequeue();
                Console.Write(node.val + " ");

                if (node.left != null)
                    queue.Enqueue(node.left);

                if (node.right != null)
                    queue.Enqueue(node.right);
            }
        }
    }
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;

        public TreeNode(int x)
        {
            val = x;
            left = null;
            right = null;
        }
    }
}
