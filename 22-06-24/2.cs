using System;

public class DelegateExample
{
    // Declare a delegate
    public delegate void DisplayMessage(string message);

    public static void Main(string[] args)
    {
        // Create delegate instances
        DisplayMessage dm1 = new DisplayMessage(ShowMessage);
        DisplayMessage dm2 = new DisplayMessage(PrintMessage);

        // Call the methods using the delegate instances
        dm1("Hello from ShowMessage!");
        dm2("Hello from PrintMessage!");

        // Using multicast delegates
        DisplayMessage multicastDelegate = dm1 + dm2;
        multicastDelegate("Hello from multicast delegate!");

        // Removing a method from the multicast delegate
        multicastDelegate -= dm1;
        multicastDelegate("Hello after removing ShowMessage!");
    }

    // Method that matches the delegate signature
    public static void ShowMessage(string message)
    {
        Console.WriteLine(message);
    }

    // Another method that matches the delegate signature
    public static void PrintMessage(string message)
    {
        Console.WriteLine(message.ToUpper());
    }
}
