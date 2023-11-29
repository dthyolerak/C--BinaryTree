class Program
{
    static void Main()
    {
        BinaryTree<int> binaryTree = new BinaryTree<int>();

        // Test cases
        binaryTree.Insert(5);
        binaryTree.Insert(3);
        binaryTree.Insert(7);
        binaryTree.Insert(2);
        binaryTree.Insert(4);
        binaryTree.Insert(6);
        binaryTree.Insert(8);

        // Inorder Traversal
        binaryTree.InOrderTraversal();

        // Postorder Traversal
        binaryTree.PostOrderTraversal();

        // Search for a node
        int searchKey = 4;
        if (binaryTree.Search(searchKey, out Node<int> foundNode, out Node<int> parentNode))
        {
            Console.WriteLine($"{searchKey} found!");
            Console.WriteLine($"Parent Node: {(parentNode != null ? parentNode.Data.ToString() : "None")}");
            Console.WriteLine($"Immediate Children: {(foundNode.Left != null ? foundNode.Left.Data.ToString() : "None")} " +
                              $"{(foundNode.Right != null ? foundNode.Right.Data.ToString() : "None")}");
        }
        else
        {
            Console.WriteLine($"{searchKey} not found!");
        }

        // Remove a node
        binaryTree.Remove(3);

        // Inorder Traversal after removal
        binaryTree.InOrderTraversal();
    }
}