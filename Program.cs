// BED-C0M-15-19 DONNEX THOLERA KAMSONGA
using System;
using System.IO;

class Program
{
    static BinaryTree<Person> binaryTree = new BinaryTree<Person>();

    static void Main()
    {
        LoadDataFromFile("COM314.txt");

        while (true)
        {
            Console.WriteLine("Select an option:");
            Console.WriteLine("1. Inorder Traversal");
            Console.WriteLine("2. Postorder Traversal");
            Console.WriteLine("3. Search by Unique ID");
            Console.WriteLine("4. Exit");

            int choice = GetUserChoice();

            switch (choice)
            {
                case 1:
                    binaryTree.InorderTraversal();
                    break;

                case 2:
                    binaryTree.PostorderTraversal();
                    break;

                case 3:
                    SearchByID();
                    break;

                case 4:
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }

    static void LoadDataFromFile(string filePath)
    {
        try
        {
            if (File.Exists(filePath))
            {
                // string[] lines = File.ReadAllLines(filePath);
                // Read all lines and remove empty lines
                string[] lines = File.ReadAllLines(filePath).Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();

                int currentIndex = 0;

                while (currentIndex < lines.Length)
                {
                    // Try to read a person's data
                    string firstName = lines[currentIndex];
                    currentIndex++;

                    if (currentIndex >= lines.Length)
                    {
                        Console.WriteLine("Error: Incomplete data for a person at line {0}. Skipping entry.", currentIndex);
                        continue;
                    }

                    string lastName = lines[currentIndex];
                    currentIndex++;

                    if (currentIndex >= lines.Length)
                    {
                        Console.WriteLine("Error: Incomplete data for a person at line {0}. Skipping entry.", currentIndex);
                        continue;
                    }

                    int age;
                    if (int.TryParse(lines[currentIndex], out age))
                    {
                        currentIndex++;

                        if (currentIndex >= lines.Length)
                        {
                            Console.WriteLine("Error: Incomplete data for a person at line {0}. Skipping entry.", currentIndex);
                            continue;
                        }

                        string uniqueID = lines[currentIndex];
                        currentIndex++;

                        Person person = new Person
                        {
                            FirstName = firstName,
                            LastName = lastName,
                            Age = age,
                            UniqueID = uniqueID
                        };

                        binaryTree.Insert(person);
                    }
                    else
                    {
                        Console.WriteLine($"Error parsing age for {firstName} {lastName} at line {currentIndex}. Skipping entry.");
                        currentIndex++;  // Jump to the next line to avoid infinite loop
                    }
                }

                Console.WriteLine("Data loaded successfully.");
            }
            else
            {
                Console.WriteLine("Error: File not found.");
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine("An error occurred while loading data: {0}", ex.Message);
        }
    }
    static void SearchByID()
    {
        Console.Write("Enter Unique ID to search: ");
        string uniqueID = Console.ReadLine();

        Person foundPerson = binaryTree.Search(p => p.UniqueID == uniqueID);

        if (foundPerson != null)
        {
            Console.WriteLine("Person found:");
            DisplayPersonDetails(foundPerson);
        }
        else
        {
            Console.WriteLine("Person not found.");
        }
    }

    static void DisplayPersonDetails(Person person)
    {
        Console.WriteLine($"First Name: {person.FirstName}");
        Console.WriteLine($"Last Name: {person.LastName}");
        Console.WriteLine($"Age: {person.Age}");
        Console.WriteLine($"Unique ID: {person.UniqueID}");
    }

    static int GetUserChoice()
    {
        int choice;
        while (!int.TryParse(Console.ReadLine(), out choice))
        {
            Console.WriteLine("Invalid input. Please enter a number.");
        }
        return choice;
    }
}

