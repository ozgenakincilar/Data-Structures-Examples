namespace BinarySearchTree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TreeNode root = null;

            // Elemanları ekleyelim
            root = Insert(root, 50);
            Insert(root, 30);
            Insert(root, 20);
            Insert(root, 40);
            Insert(root, 70);
            Insert(root, 60);
            Insert(root, 80);

            Console.WriteLine("Inorder Traversal (Sorted):");
            InorderTraversal(root);
            Console.WriteLine();

            // Bir elemanı silelim
            int valueToDelete = 30;
            root = Delete(root, valueToDelete);

            Console.WriteLine($"\nInorder Traversal after deleting {valueToDelete}:");
            InorderTraversal(root);
            Console.WriteLine();
        }

        public static TreeNode Insert(TreeNode root, int val)
        {
            if (root == null)
                return new TreeNode(val);

            if (val < root.val)
                root.left = Insert(root.left, val);
            else if (val > root.val)
                root.right = Insert(root.right, val);

            return root;
        }

        public static TreeNode Delete(TreeNode root, int key)
        {
            if (root == null)
                return root;

            if (key < root.val)
                root.left = Delete(root.left, key);
            else if (key > root.val)
                root.right = Delete(root.right, key);
            else
            {
                // Node with only one child or no child
                if (root.left == null)
                    return root.right;
                else if (root.right == null)
                    return root.left;

                // Node with two children, get the inorder successor (smallest
                // in the right subtree)
                root.val = MinValue(root.right);

                // Delete the inorder successor
                root.right = Delete(root.right, root.val);
            }

            return root;
        }

        public static int MinValue(TreeNode root)
        {
            int minValue = root.val;
            while (root.left != null)
            {
                minValue = root.left.val;
                root = root.left;
            }
            return minValue;
        }

        public static void InorderTraversal(TreeNode root)
        {
            if (root != null)
            {
                InorderTraversal(root.left);
                Console.Write(root.val + " ");
                InorderTraversal(root.right);
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
