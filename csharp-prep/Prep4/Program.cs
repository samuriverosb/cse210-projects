using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        int num;
        int sum = 0;
        float avg;
        int max = 0;
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        do
        {
            Console.Write("Enter number: ");
            string numStr = Console.ReadLine();
            num = int.Parse(numStr);
            if (num > max)
            {
                max = num;
            }
            if (num != 0)
            {
                numbers.Add(num);
            }
        } while (num != 0);

        foreach (int number in numbers)
        {
            sum += number;
        }
        Console.WriteLine($"The sum is: {sum}");

        avg = sum / numbers.Count;
        Console.WriteLine($"The average is: {avg}");
        Console.WriteLine($"The largest number is: {max}");
    }
}