using System;
using System.Collections.Generic;

public class SortNames
{
    public static void Main(string[] args)
    {
        // Declare a list to hold the names
        List <string> names = new List<string>();

        // Prompt the user to enter names
        Console.WriteLine("Enter the names (type 'done' to finish):");

        // Read names from the user until they type 'done'
        while (true)
        {
            string name = Console.ReadLine();
            if (name.ToLower() == "done")
            {
                break;
            }
            names.Add(name);
        }

        // Sort the list of names
        names.Sort();

        // Display the sorted list of names
        Console.WriteLine("Sorted list of names:");
        foreach (string name in names)
        {
            Console.Write(name + " ");
        }
    }
}
