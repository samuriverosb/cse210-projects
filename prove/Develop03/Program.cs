using System;

// I added code to the Scripture class to check if the word it is trying to hide is already hidden
// It's inside the Scripture.HideWords() method

class Program
{
    static void Main(string[] args)
    {
        Reference reference = new Reference("Moroni", 10, 4, 5);
        string strScripture = "And when ye shall receive these things, I would exhort you that ye would ask God, the Eternal Father, in the name of Christ, if these things are not true; and if ye shall ask with a sincere heart, with real intent, having faith in Christ, he will manifest the truth of it unto you, by the power of the Holy Ghost. And by the power of the Holy Ghost ye may know the truth of all things.";
        Scripture scripture = new Scripture(reference.GetReference(), strScripture);
        string input = "";

        do
        {
            scripture.DisplayScripture();
            scripture.HideWords();
            Console.WriteLine();
            Console.WriteLine("Press Enter to continue or type 'quit' to finish");
            input = Console.ReadLine();
        } while (input != "quit" && !scripture._isCompletelyHidden);
    }
}