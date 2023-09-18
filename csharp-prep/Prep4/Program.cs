using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;

class Program
{
    static void Main(string[] args)
    {
        int input = 1;
        int sum = 0;
        int listSize = 0;
        int average = 0;
        int largest = 0;
        int smallest = 0;

        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished");
        while(input != 0)
        {
            Console.Write("Enter number: ");
            input = int.Parse(Console.ReadLine());
            if (input != 0)
            {
                numbers.Add(input);
            }
        }



        foreach (int number in numbers)
        {
            sum = sum + number;
            listSize ++;
            if (listSize > 0)
            {
                average = sum/listSize;
                smallest = numbers[0];
                largest = numbers[0];
                if (number > largest)
                {
                    largest = number;
                }

                if (number < smallest)
                {
                    smallest = number;
                }
            }
        }

        numbers.Sort();

        Console.WriteLine($"Largest: {largest}");
        Console.WriteLine($"Sum: {sum}");
        Console.WriteLine($"Average: {average}");
        Console.WriteLine($"Your sorted list: ");
        foreach (int number in numbers)
        {
            Console.Write($"{number} ");
        }
    }
}