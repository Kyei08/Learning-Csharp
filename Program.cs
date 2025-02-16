using System;

public class ArrayExample
{
    public static void Main(string[] args)
    {
        // 1. Array Declaration and Initialization
        // Declare an integer array named 'numbers' with a size of 5.
        int[] numbers = new int[5];

        // Initialize the array elements.
        numbers[0] = 10;
        numbers[1] = 20;
        numbers[2] = 30;
        numbers[3] = 40;
        numbers[4] = 50;

        // Alternative initialization (array initializer)
        string[] names = { "Alice", "Bob", "Charlie", "David" };

        // 2. Accessing Array Elements
        Console.WriteLine("First number: " + numbers[0]); // Output: 10
        Console.WriteLine("Third name: " + names[2]);    // Output: Charlie

        // 3. Array Length
        Console.WriteLine("Number of elements in 'numbers': " + numbers.Length); // Output: 5
        Console.WriteLine("Number of elements in 'names': " + names.Length); // Output: 4

        // 4. Looping through an Array (using 'for' loop)
        Console.WriteLine("\nNumbers:");
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.WriteLine(numbers[i]);
        }

        Console.WriteLine("\nNames:");
        for (int i = 0; i < names.Length; i++)
        {
            Console.WriteLine(names[i]);
        }

        // 5. Looping through an Array (using 'foreach' loop)
        Console.WriteLine("\nNumbers (using foreach):");
        foreach (int number in numbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine("\nNames (using foreach):");
        foreach (string name in names)
        {
            Console.WriteLine(name);
        }

        // 6. Multidimensional Arrays (2D example)
        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        Console.WriteLine("\nMatrix:");
        for (int row = 0; row < matrix.GetLength(0); row++)
        {
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                Console.Write(matrix[row, col] + " ");
            }
            Console.WriteLine();
        }

        // 7. Array methods.
        int[] unsortedNumbers = { 5, 2, 8, 1, 9 };
        Array.Sort(unsortedNumbers); // Sorts the array.
        Console.WriteLine("\nSorted Numbers:");
        foreach (int num in unsortedNumbers)
        {
            Console.Write(num + " ");
        }

        int index = Array.IndexOf(unsortedNumbers, 8); //Finds the index of an element.
        Console.WriteLine($"\nThe index of 8 is: {index}");

        Array.Reverse(unsortedNumbers); //reverses the array.
        Console.WriteLine("\nReversed Sorted Numbers:");
        foreach (int num in unsortedNumbers)
        {
            Console.Write(num + " ");
        }
    }
}