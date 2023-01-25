using System;

class Program
{
    static void Main(string[] args)
    {
        ProgramConsole.DisplayConsole();
        string input = Console.ReadLine();
        Prompts prompt = new Prompts();
        Journal journal = new Journal();
        while (input != "5")
        {
            if (input == "1")
            {
                prompt.DisplayPrompt();
                Entry entry = new Entry();
                entry._promptGenerated = prompt.lastProduced;
                entry._input = Console.ReadLine();
                entry._currentDate = DateTime.Now.ToShortDateString();
                journal.SaveEntry(entry);
                Console.WriteLine();
                ProgramConsole.DisplayConsole();
                input = Console.ReadLine();
            }
            else if (input == "2")
            {
                journal.DisplayJournal();
                Console.WriteLine();
                ProgramConsole.DisplayConsole();
                input = Console.ReadLine();
            }
            else if (input == "3")
            {
                Files file = new Files();
                Console.Write("Please enter a .txt filename: ");
                string filename = Console.ReadLine();
                file.LoadFile(filename, journal);
                Console.WriteLine();
                ProgramConsole.DisplayConsole();
                input = Console.ReadLine();
            }
            else if (input == "4")
            {
                Files file = new Files();
                Console.Write("Please enter a .txt filename: ");
                string filename = Console.ReadLine();
                file.SaveFile(filename, journal);
                Console.WriteLine();
                ProgramConsole.DisplayConsole();
                input = Console.ReadLine();
            }
        }
        System.Environment.Exit(0);
    }
}