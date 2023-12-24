// BinaryTree.cs
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

}
