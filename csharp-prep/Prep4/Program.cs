using System;
using System.Collections.Immutable;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {

        List<int> numbers = new List<int>();
        

        // Get user numbers until they enter 0
        int userNumber = -1;
        while (userNumber != 0)
        {
            Console.Write("Enter a number (0 to quit): ");
            string userResponse = Console.ReadLine();

            // Parse input into int
            if (int.TryParse(userResponse, out userNumber))
            {
                if (userNumber != 0)
                {
                    numbers.Add(userNumber);
                }
            }
            else
            {
                Console.WriteLine("Please enter a valid integer.");
            }
        }

        // Output the results after 0 is entered
        if (numbers.Count > 0)
        {
            // Calculate Sum
            int sum = 0;
            foreach (int number in numbers)
            {
                sum += number;
            }
            Console.WriteLine($"The sum is: {sum}");

            // Compute average
            float average = ((float)sum) / numbers.Count;
            Console.WriteLine($"The average is: {average}");

            // Find max
            int max = numbers[0];
            foreach (int number in numbers)
            {
                if (number > max)
                {
                    max = number;
                }
            }
            Console.WriteLine($"The max is: {max}");
            
            // Find smallest positive number
            int? smallestPositive = null;
            foreach (int number in numbers)
            {
                if (number > 0 && (smallestPositive == null || number < smallestPositive))
                {
                    smallestPositive = number;
                }
            }
            if (smallestPositive.HasValue)
            {
                Console.WriteLine($"The smallest positive number is: {smallestPositive}");
            }
            else
            {
                Console.WriteLine("No positive numbers were entered.");
            }

            // sort numbers and display sorted list
            numbers.Sort();
            Console.WriteLine("The sorted list is: ");
            foreach (int number in numbers)
            {
                Console.WriteLine(number);
            }
        }
        else
        {
            Console.WriteLine("No numers were entered.");
        }
            
    }
}