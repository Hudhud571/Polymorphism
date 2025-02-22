using System;

// Define the IQuittable interface with a Quit method
interface IQuittable
{
    void Quit(); // Method to be implemented by classes that inherit this interface
}

// Employee class that inherits from IQuittable
class Employee : IQuittable
{
    public string Name { get; set; } // Property to store the employee's name

    // Constructor to initialize the Employee object with a name
    public Employee(string name)
    {
        Name = name;
    }

    // Implement the Quit method from the IQuittable interface
    public void Quit()
    {
        Console.WriteLine($"{Name} has decided to quit the job."); // Display a message when the employee quits
    }
}

class Program
{
    static void Main(string[] args)
    {
        // Create an instance of the Employee class
        Employee employee = new Employee("John Doe");

        // Use polymorphism to create an object of type IQuittable
        IQuittable quittable = employee; // Employee object is treated as IQuittable

        // Call the Quit method on the IQuittable object
        quittable.Quit(); // This will execute the Quit method implemented in the Employee class

        // Wait for user input before closing the console window
        Console.WriteLine("Press any key to exit...");
        Console.ReadKey();
    }
}