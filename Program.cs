// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;

public class Addition
{
    [ObsoleteAttribute ("Use the updated Add(List <int> Numbers) Method Instead.", true)]
    public static int Add1(int x, int y)
    {
        return x + y;
    }

    public static int Add2(List <int> Numbers)
    {
        int Sum = 0;
        foreach(int Number in Numbers)
        {
            Sum = Sum + Number;
        }
        return Sum;
    }
}

class Ali
{
    public static void Main()
    {
        START1:
        // Using Older Version
        // Addition.Add1(10, 20);

        // Using updated Method
        Console.WriteLine("This program adds n number of numbers.");
        Console.WriteLine("So, how many numbers do you want to add?");
        int count = Convert.ToInt32(Console.ReadLine());

        if(count > 1)
        {
            List<int> numbers = new List<int>();

            // Input the numbers from the user
            for (int i = 0; i < count; i++)
            {
                Console.WriteLine($"Enter number {i + 1}:");
                int number = Convert.ToInt32(Console.ReadLine());
                numbers.Add(number);
            }

            // Calculate the sum using the updated method
            int sum = Addition.Add2(numbers);

            // Display the result
            Console.WriteLine("The sum of the numbers is: {0}", sum);
        }
        else
        {
            Console.WriteLine("You need to have atleast 2 numbers to get added.");

            START2:
            Console.WriteLine("Do you want to try again? (yes/no)");

            string response = Console.ReadLine().ToLower();
            
            if (response == "yes")
            {
                Console.WriteLine("\n-----------------------------------------\n");
                goto START1;
            }
            else if(response == "no")
            {
                Console.WriteLine("The program has terminated.");
                return;
            }
            else
            {
                Console.WriteLine("Wrong Input! Please Try Again!");
                Console.WriteLine("\n-----------------------------------------\n");
                goto START2;
            }
        }
    }
}