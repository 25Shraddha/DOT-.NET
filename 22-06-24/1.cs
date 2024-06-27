using System;

public class Animal
{
    // Virtual method in the base class
    public virtual void MakeSound()
    {
        Console.WriteLine("The animal makes a sound.");
    }
}

public class Dog : Animal
{
    // Override the virtual method in the derived class
    public override void MakeSound()
    {
        Console.WriteLine("The dog barks.");
    }
}

public class GermanShepherd : Dog
{
    // Override the virtual method in the derived class
    public override void MakeSound()
    {
        Console.WriteLine("The German Shepherd barks loudly.");
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        // Create instances of each class
        Animal animal = new Animal();
        Dog dog = new Dog();
        GermanShepherd germanShepherd = new GermanShepherd();

        // Call the MakeSound method on each instance
        animal.MakeSound();  // Output: The animal makes a sound.
        dog.MakeSound();     // Output: The dog barks.
        germanShepherd.MakeSound();  // Output: The German Shepherd barks loudly.

        // Demonstrate polymorphism
        Animal polymorphicAnimal;

        polymorphicAnimal = new Dog();
        polymorphicAnimal.MakeSound();  // Output: The dog barks.

        polymorphicAnimal = new GermanShepherd();
        polymorphicAnimal.MakeSound();  // Output: The German Shepherd barks loudly.
    }
}
