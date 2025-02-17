using System;

public class FunctionExamples
{
    // A simple function that takes no arguments and returns no value (void).
    public static void Greet()
    {
        Console.WriteLine("Hello, World!");
    }

    // A function that takes one argument and returns no value.
    public static void GreetPerson(string name)
    {
        Console.WriteLine($"Hello, {name}!");
    }

    // A function that takes two arguments and returns a value (an integer).
    public static int Add(int a, int b)
    {
        return a + b;
    }

    // A function with optional parameters.
    public static string FormatName(string firstName, string lastName, string middleName = "")
    {
        if (string.IsNullOrEmpty(middleName))
        {
            return $"{firstName} {lastName}";
        }
        else
        {
            return $"{firstName} {middleName} {lastName}";
        }
    }

    // A function with named parameters.
    public static void PrintPersonDetails(string name, int age, string city)
    {
        Console.WriteLine($"Name: {name}, Age: {age}, City: {city}");
    }

    //A function that returns multiple values using tuples.
    public static (int sum, int product) Calculate(int a, int b)
    {
        return (a + b, a * b);
    }

    public static void Main(string[] args)
    {
        // Calling the Greet function.
        Greet();

        // Calling the GreetPerson function.
        GreetPerson("Alice");

        // Calling the Add function and storing the result.
        int sum = Add(5, 3);
        Console.WriteLine($"5 + 3 = {sum}");

        //Using optional parameters
        string fullName1 = FormatName("John", "Doe");
        string fullName2 = FormatName("Jane", "Smith", "Middle");
        Console.WriteLine(fullName1);
        Console.WriteLine(fullName2);

        //Using named parameters
        PrintPersonDetails(name: "Bob", age: 30, city: "New York");

        //Using tuples to return multiple values.
        (int sumResult, int productResult) = Calculate(4,6);
        Console.WriteLine($"Sum: {sumResult}, Product: {productResult}");

        //You can also deconstruct tuples inline.
        var (sumInline, productInline) = Calculate(2,3);
        Console.WriteLine($"Inline Sum: {sumInline}, Inline Product: {productInline}");

    }
}