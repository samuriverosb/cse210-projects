using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Introduce your grade percentage: ");
        string gradeString = Console.ReadLine();
        int grade = int.Parse(gradeString);
        string letter;

        if (grade >= 90)
        {
            letter = "A";
        }
        else if (grade >= 80)
        {
            letter = "B";
        }
        else if (grade >= 70)
        {
            letter = "C";
        }
        else if (grade >= 60)
        {
            letter = "D";
        }
        else
        {
            letter = "F";
        }

        string sign;
        if (grade % 10 >= 7)
        {
            sign = "+";
        }
        else if (grade % 10 < 3)
        {
            sign = "-";
        }
        else
        {
            sign = "";
        }

        Console.WriteLine($"Your grade is {letter}{sign}");
        if (grade > 70)
        {
            Console.WriteLine("Congrats on passing!");
        }
        else
        {
            Console.WriteLine("Better Luck next time!");
        }
    }
}