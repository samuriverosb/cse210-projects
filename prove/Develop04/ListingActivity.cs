using System;

public class ListingActivity : Activity
{
	private List<string> _prompts = new List<string>();
	private void PopulatePrompts()
	{
		_prompts.Add("Who are people that you appreciate?");
        _prompts.Add("What are personal strengths of yours?");
        _prompts.Add("Who are people that you have helped this week?");
        _prompts.Add("When have you felt the Holy Ghost this month?");
        _prompts.Add("Who are some of your personal heroes?");
	}

	private List<string> _answers = new List<string>();

	public ListingActivity(string activity, string description) : base(activity, description)
	{
		PopulatePrompts();
		base.StartingMessage();
		StartActivity();
	}

	private string RandomPrompt()
	{
		Random random = new Random();
		int randomIndex = random.Next(0, _prompts.Count);
		string prompt = _prompts[randomIndex];

		return prompt;
	}

	private void Countdown()
	{
		Console.CursorVisible = false;
		int seconds = 5;

		while (seconds > 0)
		{
			Console.Write(seconds + " ");
			seconds--;
			Thread.Sleep(1050);
			Console.Write("\b \b");
			Console.Write("\b \b");
		}
	}

	private void StartActivity()
	{
		base.GetReady();
		Console.WriteLine();
		Console.WriteLine("List as many responses as you can to the following prompt:");
		Console.WriteLine($"--- {RandomPrompt()} ---");
		Console.Write("You may begin in: ");
		Countdown();
		Console.WriteLine();
		DateTime stopTime = DateTime.Now.AddSeconds(base.GetTime());
		while (DateTime.Now <= stopTime)
		{
			Console.Write("> ");
			_answers.Add(Console.ReadLine());
		}
		Console.WriteLine($"You listed {_answers.Count} items!");
		base.EndingMessage();
	}
}