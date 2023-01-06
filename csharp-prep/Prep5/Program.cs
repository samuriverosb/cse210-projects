using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayWelcome();
        string name = PromptUserName();
        int number = PromptUserNumber();
        DisplayResult(name, number);
    }

    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();
        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        string numberStr = Console.ReadLine();
        int number = int.Parse(numberStr);
        return number;
    }

    static void DisplayResult(string name, int number)
    {
        number = number * number;
        Console.WriteLine($"{name}, the square of your number is {number}");
    }
}