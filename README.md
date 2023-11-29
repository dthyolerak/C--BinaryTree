# C--BinaryTree
Problem: For this task I will be required to develop a Binary Tree data structure. The Binary Tree will be implemented using C Sharp Generic methods and classes.

> [!NOTE]
## Here's the expected result for the provided program:
1. Inorder Traversal: 2 3 4 5 6 7 8 
2. Postorder Traversal: 2 4 3 6 8 7 5 
3. 4 found!
4. Parent Node: 3
5. Immediate Children: 2 6 
6. Inorder Traversal: 2 4 5 6 7 8 

## This output corresponds to the following actions in the program:
1. Nodes 2, 3, 4, 5, 6, 7, 8 are inserted into the Binary Tree.
2. Inorder Traversal displays the nodes in sorted order.
3. Postorder Traversal displays the nodes in postorder traversal.
4. The program searches for the node with the key 4 and outputs information about its 
5. existence, parent node, and immediate children.
6. The node with the key 3 is removed from the Binary Tree.
7. Inorder Traversal after removal displays the updated tree.

> [!TIP]
## To test with other examples, you can modify the Main method in the Program.cs file. Here are some examples:
### Example 1: Testing with Strings
class Program
{
    static void Main()
    {
        BinaryTree<string> binaryTree = new BinaryTree<string>();

        binaryTree.Insert("apple");
        binaryTree.Insert("banana");
        binaryTree.Insert("orange");
        binaryTree.Insert("grape");
        binaryTree.Insert("kiwi");

    }
}
### Example 2: Testing with Custom Objects
class CustomObject
{
    public int Id { get; set; }
    public string Name { get; set; }
}

class Program
{
    static void Main()
    {
        BinaryTree<CustomObject> binaryTree = new BinaryTree<CustomObject>();

        binaryTree.Insert(new CustomObject { Id = 1, Name = "Object1" });
        binaryTree.Insert(new CustomObject { Id = 2, Name = "Object2" });
        binaryTree.Insert(new CustomObject { Id = 3, Name = "Object3" });
    }
}
