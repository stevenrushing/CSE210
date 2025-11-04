using System;
using System.Collections.Generic;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        int endNum = 1;
        List<int> numbers = new List<int>();
        while (endNum != 0)
        {
            string entry = Console.ReadLine();
            endNum = int.Parse(entry);
            numbers.Add(endNum);
        }
        int total = 0;
        foreach (int number in numbers)
        {
            total += number;
        }
        int average = total / (numbers.Count - 1);
        Console.WriteLine($"The sum is: {total}");
        Console.WriteLine($"The average is: {average}");
    }
}

// Enter a list of numbers, type 0 when finished.
//   Enter number: 18
//   Enter number: 36
//   Enter number: 2
//   Enter number: 48
//   Enter number: 6
//   Enter number: 12
//   Enter number: 9
//   Enter number: 0
//   The sum is: 131
//   The average is: 18.714285714285715
//   The largest number is: 48