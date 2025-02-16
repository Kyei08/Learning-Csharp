using System;

public class TemperatureChecker
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter the current temperature in Celsius:");

        // Attempt to parse the user's input as a double.
        if (double.TryParse(Console.ReadLine(), out double temperature))
        {
            // The input was successfully parsed.
            if (temperature > 30)
            {
                Console.WriteLine("It's a hot day!");
            }

            if (temperature < 10)
            {
                Console.WriteLine("It's quite cold.");
            }

            if (temperature >= 10 && temperature <= 30)
            {
                Console.WriteLine("The temperature is moderate");
            }

            //Example of if else, and else if.
            if (temperature < 0)
            {
                Console.WriteLine("It's freezing!");
            }
            else if (temperature >= 0 && temperature < 10)
            {
                Console.WriteLine("It's chilly.");
            }
            else
            {
                Console.WriteLine("It's not freezing or chilly.");
            }
        }
        else
        {
            // The input was not a valid number.
            Console.WriteLine("Invalid input. Please enter a valid temperature.");
        }

        Console.WriteLine("Program End");
    }
}