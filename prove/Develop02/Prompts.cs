using System;

public class Prompts
{
    public string[] _listOfPrompts =
    {
        "Who was the most interesting person I interacted with today?",
        "What was the best part of my day?",
        "How did I see the hand of the Lord in my life today?",
        "What was the strongest emotion I felt today?",
        "If I had one thing I could do over today, what would it be?",
        "What did you learn today?",
        "Were you happy today?",
        "Did you eat healthy today?"
    };
    public string lastProduced;
    public void DisplayPrompt()
    {
        Random random = new Random();
        int randomNumber = random.Next(0, 7);
        if (lastProduced == null)
        {
            Console.WriteLine(_listOfPrompts[randomNumber]);
            lastProduced = _listOfPrompts[randomNumber];
        }
        else if (lastProduced != _listOfPrompts[randomNumber])
        {
            Console.WriteLine(_listOfPrompts[randomNumber]);
            lastProduced = _listOfPrompts[randomNumber];
        }
        else
        {
            if (randomNumber == 7)
            {
                Console.WriteLine(_listOfPrompts[6]);
                lastProduced = _listOfPrompts[6];
            }
            else if (randomNumber == 0)
            {
                Console.WriteLine(_listOfPrompts[1]);
                lastProduced = _listOfPrompts[1];
            }
            else
            {
                Console.WriteLine(_listOfPrompts[randomNumber + 1]);
                lastProduced = _listOfPrompts[randomNumber + 1];
            }
        }
    }
}