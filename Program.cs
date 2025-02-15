using System;

public class UserInputAddTen
{
    public static void Main(string[] args)
    {
        Console.Write("Enter a number: ");

        // Attempt to parse the user's input as an integer.
        if (int.TryParse(Console.ReadLine(), out int userInput))
        {
            // If parsing is successful, add 10 and display the result.
            int result = userInput + 10;
            Console.WriteLine("Result: " + result);
        }
        else
        {
            // If parsing fails, inform the user that their input was invalid.
            Console.WriteLine("Invalid input. Please enter a valid integer.");
        }
    }
}
