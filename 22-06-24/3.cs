using System;

public class Node
{
    public int Data;
    public Node Next;

    public Node(int data)
    {
        Data = data;
        Next = null;
    }
}

public class LinkedList
{
    private Node head;

    public LinkedList()
    {
        head = null;
    }

    // Method to add a node at the end of the linked list
    public void AddNode(int data)
    {
        Node newNode = new Node(data);
        if (head == null)
        {
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.Next != null)
            {
                current = current.Next;
            }
            current.Next = newNode;
        }
    }

    // Method to traverse the linked list and print each node's data
    public void Traverse()
    {
        if (head == null)
        {
            Console.WriteLine("The linked list is empty.");
            return;
        }

        Node current = head;
        while (current != null)
        {
            Console.Write(current.Data + " ");
            current = current.Next;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        LinkedList linkedList = new LinkedList();

        // Add nodes to the linked list
        linkedList.AddNode(1);
        linkedList.AddNode(2);
        linkedList.AddNode(3);
        linkedList.AddNode(4);
        linkedList.AddNode(5);

        // Traverse and print the linked list
        Console.WriteLine("The elements in the linked list are:");
        linkedList.Traverse();
    }
}
