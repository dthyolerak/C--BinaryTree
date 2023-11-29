public class BinaryTree<T> where T : IComparable<T>
{
    private Node<T> root;

    public void Insert(T data)
    {
        root = InsertRecursive(root, data);
    }

    private Node<T> InsertRecursive(Node<T> node, T data)
    {
        if (node == null)
        {
            return new Node<T>(data);
        }

        if (data.CompareTo(node.Data) < 0)
        {
            node.Left = InsertRecursive(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            node.Right = InsertRecursive(node.Right, data);
        }

        return node;
    }

    public bool Search(T data, out Node<T> foundNode, out Node<T> parentNode)
    {
        foundNode = null;
        parentNode = null;
        return SearchRecursive(root, data, ref foundNode, ref parentNode);
    }

    private bool SearchRecursive(Node<T> node, T data, ref Node<T> foundNode, ref Node<T> parentNode)
    {
        if (node == null)
        {
            return false;
        }

        if (data.CompareTo(node.Data) == 0)
        {
            foundNode = node;
            return true;
        }

        parentNode = node;

        if (data.CompareTo(node.Data) < 0)
        {
            return SearchRecursive(node.Left, data, ref foundNode, ref parentNode);
        }
        else
        {
            return SearchRecursive(node.Right, data, ref foundNode, ref parentNode);
        }
    }

    public void Remove(T data)
    {
        root = RemoveRecursive(root, data);
    }

    private Node<T> RemoveRecursive(Node<T> node, T data)
    {
        if (node == null)
        {
            return null;
        }

        if (data.CompareTo(node.Data) < 0)
        {
            node.Left = RemoveRecursive(node.Left, data);
        }
        else if (data.CompareTo(node.Data) > 0)
        {
            node.Right = RemoveRecursive(node.Right, data);
        }
        else
        {
            if (node.Left == null)
            {
                return node.Right;
            }
            else if (node.Right == null)
            {
                return node.Left;
            }

            node.Data = FindMin(node.Right);
            node.Right = RemoveRecursive(node.Right, node.Data);
        }

        return node;
    }

    private T FindMin(Node<T> node)
    {
        while (node.Left != null)
        {
            node = node.Left;
        }

        return node.Data;
    }

    public void InOrderTraversal()
    {
        Console.Write("Inorder Traversal: ");
        InOrderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void InOrderTraversalRecursive(Node<T> node)
    {
        if (node != null)
        {
            InOrderTraversalRecursive(node.Left);
            Console.Write(node.Data + " ");
            InOrderTraversalRecursive(node.Right);
        }
    }

    public void PostOrderTraversal()
    {
        Console.Write("Postorder Traversal: ");
        PostOrderTraversalRecursive(root);
        Console.WriteLine();
    }

    private void PostOrderTraversalRecursive(Node<T> node)
    {
        if (node != null)
        {
            PostOrderTraversalRecursive(node.Left);
            PostOrderTraversalRecursive(node.Right);
            Console.Write(node.Data + " ");
        }
    }
}
