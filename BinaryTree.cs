public class BinaryTree<T>
{
    private class Node
    {
        public T Data { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(T data)
        {
            Data = data;
            Left = null;
            Right = null;
        }
    }

    private Node root;

    public void Insert(T data)
    {
        root = InsertRec(root, data);
    }

    private Node InsertRec(Node root, T data)
    {
        if (root == null)
        {
            root = new Node(data);
            return root;
        }

        // Assuming the tree is sorted based on age
        dynamic rootAge = typeof(T).GetProperty("Age").GetValue(root.Data);
        dynamic dataAge = typeof(T).GetProperty("Age").GetValue(data);

        if (dataAge < rootAge)
            root.Left = InsertRec(root.Left, data);
        else if (dataAge > rootAge)
            root.Right = InsertRec(root.Right, data);

        return root;
    }

    public T Search(Func<T, bool> predicate)
    {
        return Search(root, predicate);
    }

    private T Search(Node root, Func<T, bool> predicate)
    {
        if (root == null)
            return default(T);

        if (predicate(root.Data))
            return root.Data;

        T leftResult = Search(root.Left, predicate);
        if (leftResult != null)
            return leftResult;

        return Search(root.Right, predicate);
    }

    public void InorderTraversal()
    {
        
    }

    private void InorderTraversal(Node root)
    {
        
    }

    public void PostorderTraversal()
    {
        
    }

    private void PostorderTraversal(Node root)
    {
       
    }

    private void DisplayNode(Node node)
    {
        Console.WriteLine($"Data: {node.Data}");
    }

}
