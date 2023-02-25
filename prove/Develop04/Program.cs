using System;

class Program
{
    static void Main(string[] args)
    {
        string choice = "";

        while (choice != "4")
        {
            Menu menu = new Menu();
            menu.DisplayMenu();
            choice = Console.ReadLine();
            
            if (choice == "1")
            {
                BreathingActivity breath = new BreathingActivity("Breathing Activity", "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
            }
            else if (choice == "2")
            {
                ReflectionActivity reflection = new ReflectionActivity("Reflection Activity", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
            }
            else if (choice == "3")
            {
                ListingActivity listing = new ListingActivity("Listing Activity", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
            }
        }
    }
}