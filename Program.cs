/****************************************
* Name: Breanna Gonzalez
* Date: 10.25.26
* Assignment: 3.5 Performance Assessment - Calculations & Unique Numbers
*
* Description: Application demonstrates the use of array and list objects 
*/


using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        // Display the assignment heading
        Console.WriteLine("Breanna Gonzalez - Week 3 PA Calculations & Unique Numbers");
        Console.WriteLine();

        // Create an array to store 10 integers
        int[] numbers = new int[10];

        // Create a List to store unique numbers
        List<int> uniqueNumbers = new List<int>();

        // Get 10 integers from the user
        for (int i = 0; i < numbers.Length; i++)
        {
            Console.Write("Enter integer " + (i + 1) + ": ");
            numbers[i] = Convert.ToInt32(Console.ReadLine());

            // Add the number only if it is not already in the List
            if (!uniqueNumbers.Contains(numbers[i]))
            {
                uniqueNumbers.Add(numbers[i]);
            }
        }

        Console.WriteLine();

        // Display array information
        Console.WriteLine("Array Results");
        Console.WriteLine("Count: " + numbers.Length);
        Console.WriteLine("Sum: " + Sum(numbers));
        Console.WriteLine("Average: " +
            (double)Sum(numbers) / numbers.Length);

        Console.WriteLine();

        // Display List information
        Console.WriteLine("Unique Numbers List Results");
        Console.WriteLine("Count: " + uniqueNumbers.Count);
        Console.WriteLine("Sum: " + Sum(uniqueNumbers));
        Console.WriteLine("Average: " +
            (double)Sum(uniqueNumbers) / uniqueNumbers.Count);

        Console.WriteLine();
        Console.WriteLine("Unique numbers:");

        foreach (int number in uniqueNumbers)
        {
            Console.WriteLine(number);
        }

        Console.WriteLine();
        Console.WriteLine("Press any key to exit.");
        Console.ReadKey();
    }

    // Method to calculate the sum of an array
    static int Sum(int[] numbers)
    {
        int total = 0;

        for (int i = 0; i < numbers.Length; i++)
        {
            total += numbers[i];
        }

        return total;
    }

    // Overloaded method to calculate the sum of a List
    static int Sum(List<int> numbers)
    {
        int total = 0;

        for (int i = 0; i < numbers.Count; i++)
        {
            total += numbers[i];
        }

        return total;
    }
}

