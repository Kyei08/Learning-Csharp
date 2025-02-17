using System;
using System.Collections.Generic;

public class ListExample
{
    public static void Main(string[] args)
    {
        // Creating a List of strings
        List<string> names = new List<string>();

        // Adding elements to the List
        names.Add("Alice");
        names.Add("Bob");
        names.Add("Charlie");
        names.Add("David");

        // Inserting an element at a specific index
        names.Insert(1, "Eve"); // Inserts "Eve" at index 1

        // Accessing elements by index
        Console.WriteLine("Element at index 0: " + names[0]); // Output: Alice
        Console.WriteLine("Element at index 2: " + names[2]); // Output: Charlie

        // Iterating through the List using a for loop
        Console.WriteLine("\nUsing for loop:");
        for (int i = 0; i < names.Count; i++)
        {
            Console.WriteLine(names[i]);
        }

        // Iterating through the List using a foreach loop
        Console.WriteLine("\nUsing foreach loop:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Checking if an element exists
        bool containsBob = names.Contains("Bob");
        Console.WriteLine("\nList contains Bob: " + containsBob); // Output: True

        // Finding the index of an element
        int indexOfCharlie = names.IndexOf("Charlie");
        Console.WriteLine("Index of Charlie: " + indexOfCharlie); // Output: 3

        // Removing an element
        names.Remove("Eve");

        // Removing an element at a specific index
        names.RemoveAt(0);

        Console.WriteLine("\nList after removals:");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // Getting the number of elements in the List
        int count = names.Count;
        Console.WriteLine("\nNumber of elements: " + count); // Output: 3

        // Clearing the List
        names.Clear();

        // Checking if the List is empty
        bool isEmpty = (names.Count == 0);
        Console.WriteLine("List is empty: " + isEmpty); // Output: True

        // Example with a list of integers:
        List<int> numbers = new List<int>();
        numbers.Add(1);
        numbers.Add(2);
        numbers.Add(3);

        int sum = 0;
        foreach(int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"\nSum of numbers: {sum}"); // Output: Sum of numbers: 6

        //Example with a list of custom objects:
        List<Person> people = new List<Person>();
        people.Add(new Person { Name = "John", Age = 30 });
        people.Add(new Person { Name = "Jane", Age = 25 });

        foreach(Person person in people)
        {
            Console.WriteLine($"\nPerson: Name={person.Name}, Age={person.Age}");
        }
    }

    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
    }
}