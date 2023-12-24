# Binary Tree Implementation in C#

## Overview

This project implements a binary tree in C# to store information about people. The `BinaryTree<T>` class is designed to work with elements of type `T`, where `T` represents a person with properties such as FirstName, LastName, Age, and UniqueID.

## Features

- **Insertion**: Elements are inserted into the binary tree based on their UniqueID.
- **Traversal**: Inorder and postorder traversals are available for displaying elements.
- **Search**: Users can search for a person in the binary tree by UniqueID.

## Usage

### Inserting Data

To insert data into the binary tree, create an instance of `BinaryTree<Person>` and use the `Insert` method:

```csharp
BinaryTree<Person> binaryTree = new BinaryTree<Person>();
Person person = new Person { /* ... initialize properties ... */ };
binaryTree.Insert(person);
